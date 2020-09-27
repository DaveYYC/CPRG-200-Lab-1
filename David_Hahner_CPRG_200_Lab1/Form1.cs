using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Calculator to create an energy bill from kWh usage by customer type.
 * Created for use by the City Power Company.
 * Author: David Hahner
 * Date: August 2020
*/

namespace David_Hahner_CPRG_200_Lab1
{
    public partial class FrmCustomerBill : Form
    {
        // form-level declarations    
        const decimal RES_FLATRATE = 6.00m;         // residential base rate
        const decimal RES_KWHRATE = 0.052m;         // residential rate per kWh 
        const decimal COM_FLATRATE = 60m;           // commercial base rate
        const decimal COM_KWHRATE = 0.045m;         // commercial rate per kWh
        const decimal IND_FLATRATE = 76.00m;        // industrial peak hour base rate
        const decimal IND_KWHRATE = 0.065m;         // industrial peak hour rate per kWh
        const decimal IND_OFF_PK_FLATRATE = 40.00m; // industrial off-peak hour base rate
        const decimal IND_OFF_PK_KWHRATE = 0.028m;  // industrial off-peak hour rate per kWh
        const decimal FLATRTCAP = 1000;             // variable used to identify first 1000 kWh consumed
     
        public FrmCustomerBill()
        {
            
            InitializeComponent();

            // intial form visible lablel/text box settings
            lblPk_kWh.Visible = false;           // hides the peak power label
            lblOffPk_kWh.Visible = false;        // hides the off peak power label
            txtOffPk_kWh.Visible = false;        // hides the off peak power text
            this.ActiveControl = txtkWhConsumed; // adds focus to the kWhConsumed text box
            radRes.Checked = true;  // residential customer set as default as the program starts
        }

        // visible lablel/text box settings when residential customer radio button selected
        private void radRes_CheckedChanged(object sender, EventArgs e)
        {
            lblPowerConsumed.Visible = true; // makes the power consumption text appear
            lblPk_kWh.Visible = false;       // hides the peak power label
            lblOffPk_kWh.Visible = false;    // hides the off peak power label
            txtOffPk_kWh.Visible = false;    // hides the off peak power text
            txtkWhConsumed.Focus();          // adds focus to the kWhConsumed text box
        }

        // visible lablel/text box settings when commercial customer radio button selected
        private void radCom_CheckedChanged(object sender, EventArgs e)
        {
            lblPowerConsumed.Visible = true; // makes the power consumption text appear
            lblPk_kWh.Visible = false;       // hides the peak power label
            lblOffPk_kWh.Visible = false;    // hides the off peak power label
            txtOffPk_kWh.Visible = false;    // hides the off peak power text
            txtkWhConsumed.Focus();          // adds focus to the kWhConsumed text box
        }

        // visible lablel/text box settings when industrial customer radio button selected
        private void radInd_CheckedChanged(object sender, EventArgs e)
        {
            lblPk_kWh.Visible = true;         // shows the peak power text
            lblPowerConsumed.Visible = false; // makes the power consumption text dissappear
            lblOffPk_kWh.Visible = true;      // shows the off peak power label
            txtOffPk_kWh.Visible = true;      // shows the off peak power text
            txtkWhConsumed.Focus();           // adds focus to the kWhConsumed text box
        }

        // allows the calculation of the cost of power based on the customer selected,
        // validating the data entry
        private void btnCalculate_Click(object sender, EventArgs e)
        { 
            if (radRes.Checked) // residential customer radio button selected
            {
                // validation methods to make sure user input is correct for residential customer
                if (Validator.IsProvided(txtkWhConsumed, "kWh Consumed") &&
                    Validator.IsNonNegativeInt(txtkWhConsumed, "kWh Consumed")
                    )
                CalculateRes(); // method for residential customer calculation
            }

            else if (radCom.Checked) // commercial customer radio button selected
            {
                // validation methods to make sure user input is correct for commercial customer
                if (Validator.IsProvided(txtkWhConsumed, "kWh Consumed") &&
                    Validator.IsNonNegativeInt(txtkWhConsumed, "kWh Consumed")
                   )
                CalculateCom(); // method for commercial customer calculation
            }

            else // if residentail or commercial customer type is not selected, proceeds to the industrial customer
            {
                // validation methods to make sure user input is correct for industrial customer
                if (Validator.IsProvided(txtkWhConsumed, "Peak Power Consumption") &&
                    Validator.IsNonNegativeInt(txtkWhConsumed, "Peak Power Consumption") &&
                    Validator.IsProvided(txtOffPk_kWh, "Off-Peak Power Consumption") &&
                     Validator.IsNonNegativeInt(txtOffPk_kWh, "Off-Peak Power Consumption")
                     )
                CalculateInd(); // method for industrial customer calculation
            }
        }

        // calculation of energy bill for residential customer after validation
        public void CalculateRes()
        {
            // local declarations
            decimal energyUsed; // kWh consumed (input)
            decimal energyBill; // energy bill amount in $ (output)

            // obtain KwH consumed input 
            energyUsed = Convert.ToDecimal(txtkWhConsumed.Text);

            // calculate the charges as the energy bill
            energyBill = RES_FLATRATE + energyUsed * RES_KWHRATE;

            // display energy bill amount output in $0.00 format
            txtChargedAmount.Text = energyBill.ToString("c");
        }

        // calculation of energy bill for commercial customer after validation
        public void CalculateCom()
        {
            // local declarations
            decimal energyUsed; // kWh consumed (input)
            decimal energyBill; // energy bill amount in $ (output)

            // obtain KwH consumed input 
            energyUsed = Convert.ToDecimal(txtkWhConsumed.Text);

            if (energyUsed <= FLATRTCAP)
            {
                // calculate the charge as the energy bill
                energyBill = COM_FLATRATE;

                // display energy bill amount output in $0.00 format
                txtChargedAmount.Text = energyBill.ToString("c");
            }
            else
            {
                // calculate the charges as the energy bill
                energyBill = COM_FLATRATE + (energyUsed - FLATRTCAP) * COM_KWHRATE;

                // display energy bill amount output in $0.00 format
                txtChargedAmount.Text = energyBill.ToString("c");
            }
        }

        // calculation of energy bill for industrial customer after validation
        private void CalculateInd()
        {
            //local declarations
            decimal energyUsedPeak = Convert.ToDecimal(txtkWhConsumed.Text); // kWh consumed during peak hours (input)
            decimal energyUsedOff = Convert.ToDecimal(txtOffPk_kWh.Text);    // kWh consumed during off peak hours (input)
            decimal peakCost = 0;        // cost incurred from peak hour kWh consumed
            decimal offPkCost = 0;       // cost incurred from off peak hour kWh consumed
            decimal combinedCost = 0;    // cost of peak and off peak consumption above the cap
            decimal combinedLessCap = 0; // cost of peak and off peak consumption below the cap
            decimal totalCost;           // total cost of all scenarios combined
            decimal energyBill;          // energy bill amount in $ (output)

            // calculate industrial charge of kWh consumed based on peak and off-peak consumption scenarios 
            if (energyUsedPeak <= FLATRTCAP && energyUsedOff == 0)
                peakCost = IND_FLATRATE;
            else if (energyUsedPeak > FLATRTCAP && energyUsedOff == 0)
                peakCost = IND_FLATRATE + (energyUsedPeak - FLATRTCAP) * IND_KWHRATE;
            else if (energyUsedOff <= FLATRTCAP && energyUsedPeak == 0)
                offPkCost = IND_OFF_PK_FLATRATE;
            else if (energyUsedOff > FLATRTCAP && energyUsedPeak == 0)
                offPkCost = IND_OFF_PK_FLATRATE + (energyUsedOff - FLATRTCAP) * IND_OFF_PK_KWHRATE;
            else if (energyUsedOff <= FLATRTCAP && energyUsedPeak <= FLATRTCAP)
                combinedLessCap = IND_OFF_PK_FLATRATE + IND_FLATRATE;
            else
                combinedCost = IND_OFF_PK_FLATRATE + (energyUsedOff - FLATRTCAP) * IND_OFF_PK_KWHRATE +
                    IND_FLATRATE + (energyUsedPeak - FLATRTCAP) * IND_KWHRATE;

            // add all scenario charges together as the energy bill
            totalCost = peakCost + offPkCost + combinedCost + combinedLessCap;
            energyBill = totalCost;

            // display energy bill amount output in $0.00 format
            txtChargedAmount.Text = energyBill.ToString("c");
        }

        // clears all fields for new inputs and resets to the residential customer as the default
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtkWhConsumed.Text = "";
            txtkWhConsumed.Focus();
            txtChargedAmount.Text = "";
            txtOffPk_kWh.Text = "";
            lblPk_kWh.Visible = false;
            txtOffPk_kWh.Visible = false;
            radRes.Checked = true;
        }

        // closes the form when exit button selected
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
