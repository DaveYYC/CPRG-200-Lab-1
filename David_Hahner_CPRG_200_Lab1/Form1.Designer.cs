namespace David_Hahner_CPRG_200_Lab1
{
    partial class FrmCustomerBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerBill));
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtkWhConsumed = new System.Windows.Forms.TextBox();
            this.lblPowerConsumed = new System.Windows.Forms.Label();
            this.lblAmountCharged = new System.Windows.Forms.Label();
            this.txtChargedAmount = new System.Windows.Forms.TextBox();
            this.radInd = new System.Windows.Forms.RadioButton();
            this.radCom = new System.Windows.Forms.RadioButton();
            this.radRes = new System.Windows.Forms.RadioButton();
            this.txtOffPk_kWh = new System.Windows.Forms.TextBox();
            this.lblOffPk_kWh = new System.Windows.Forms.Label();
            this.lblPk_kWh = new System.Windows.Forms.Label();
            this.lblCPC = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.grpCustBill = new System.Windows.Forms.GroupBox();
            this.grpCustomer.SuspendLayout();
            this.grpCustBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LawnGreen;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(577, 278);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(106, 39);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(445, 278);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 39);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(622, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 36);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtkWhConsumed
            // 
            this.txtkWhConsumed.AcceptsReturn = true;
            this.txtkWhConsumed.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtkWhConsumed.CausesValidation = false;
            this.txtkWhConsumed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtkWhConsumed.Location = new System.Drawing.Point(331, 45);
            this.txtkWhConsumed.Name = "txtkWhConsumed";
            this.txtkWhConsumed.Size = new System.Drawing.Size(106, 28);
            this.txtkWhConsumed.TabIndex = 3;
            this.txtkWhConsumed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPowerConsumed
            // 
            this.lblPowerConsumed.AutoSize = true;
            this.lblPowerConsumed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerConsumed.ForeColor = System.Drawing.Color.Black;
            this.lblPowerConsumed.Location = new System.Drawing.Point(8, 45);
            this.lblPowerConsumed.Name = "lblPowerConsumed";
            this.lblPowerConsumed.Size = new System.Drawing.Size(241, 24);
            this.lblPowerConsumed.TabIndex = 4;
            this.lblPowerConsumed.Text = "Power Consumption (kWh):";
            this.lblPowerConsumed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmountCharged
            // 
            this.lblAmountCharged.AutoSize = true;
            this.lblAmountCharged.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountCharged.ForeColor = System.Drawing.Color.Black;
            this.lblAmountCharged.Location = new System.Drawing.Point(8, 150);
            this.lblAmountCharged.Name = "lblAmountCharged";
            this.lblAmountCharged.Size = new System.Drawing.Size(176, 24);
            this.lblAmountCharged.TabIndex = 13;
            this.lblAmountCharged.Text = "Energy Bill Amount:";
            this.lblAmountCharged.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtChargedAmount
            // 
            this.txtChargedAmount.BackColor = System.Drawing.SystemColors.Menu;
            this.txtChargedAmount.Location = new System.Drawing.Point(331, 150);
            this.txtChargedAmount.Name = "txtChargedAmount";
            this.txtChargedAmount.ReadOnly = true;
            this.txtChargedAmount.Size = new System.Drawing.Size(106, 28);
            this.txtChargedAmount.TabIndex = 0;
            this.txtChargedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radInd
            // 
            this.radInd.AutoSize = true;
            this.radInd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.radInd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radInd.Location = new System.Drawing.Point(20, 150);
            this.radInd.Name = "radInd";
            this.radInd.Size = new System.Drawing.Size(105, 28);
            this.radInd.TabIndex = 3;
            this.radInd.Text = "Industrial";
            this.radInd.UseVisualStyleBackColor = false;
            this.radInd.CheckedChanged += new System.EventHandler(this.radInd_CheckedChanged);
            // 
            // radCom
            // 
            this.radCom.AutoSize = true;
            this.radCom.BackColor = System.Drawing.Color.LightSteelBlue;
            this.radCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radCom.Location = new System.Drawing.Point(20, 97);
            this.radCom.Name = "radCom";
            this.radCom.Size = new System.Drawing.Size(132, 28);
            this.radCom.TabIndex = 2;
            this.radCom.Text = "Commercial";
            this.radCom.UseVisualStyleBackColor = false;
            this.radCom.CheckedChanged += new System.EventHandler(this.radCom_CheckedChanged);
            // 
            // radRes
            // 
            this.radRes.AutoSize = true;
            this.radRes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.radRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radRes.Location = new System.Drawing.Point(20, 47);
            this.radRes.Name = "radRes";
            this.radRes.Size = new System.Drawing.Size(123, 28);
            this.radRes.TabIndex = 1;
            this.radRes.Text = "Residential";
            this.radRes.UseVisualStyleBackColor = false;
            this.radRes.CheckedChanged += new System.EventHandler(this.radRes_CheckedChanged);
            // 
            // txtOffPk_kWh
            // 
            this.txtOffPk_kWh.AcceptsReturn = true;
            this.txtOffPk_kWh.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtOffPk_kWh.CausesValidation = false;
            this.txtOffPk_kWh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtOffPk_kWh.Location = new System.Drawing.Point(331, 94);
            this.txtOffPk_kWh.Name = "txtOffPk_kWh";
            this.txtOffPk_kWh.Size = new System.Drawing.Size(106, 28);
            this.txtOffPk_kWh.TabIndex = 4;
            this.txtOffPk_kWh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOffPk_kWh
            // 
            this.lblOffPk_kWh.AutoSize = true;
            this.lblOffPk_kWh.Location = new System.Drawing.Point(8, 97);
            this.lblOffPk_kWh.Name = "lblOffPk_kWh";
            this.lblOffPk_kWh.Size = new System.Drawing.Size(317, 24);
            this.lblOffPk_kWh.TabIndex = 16;
            this.lblOffPk_kWh.Text = "Off-Peak Power Consumption (kWh):";
            // 
            // lblPk_kWh
            // 
            this.lblPk_kWh.AutoSize = true;
            this.lblPk_kWh.Location = new System.Drawing.Point(6, 47);
            this.lblPk_kWh.Name = "lblPk_kWh";
            this.lblPk_kWh.Size = new System.Drawing.Size(288, 24);
            this.lblPk_kWh.TabIndex = 13;
            this.lblPk_kWh.Text = "Peak Power Consumption (kWh):";
            // 
            // lblCPC
            // 
            this.lblCPC.AutoSize = true;
            this.lblCPC.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblCPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPC.Location = new System.Drawing.Point(194, 15);
            this.lblCPC.Name = "lblCPC";
            this.lblCPC.Size = new System.Drawing.Size(311, 36);
            this.lblCPC.TabIndex = 18;
            this.lblCPC.Text = "City Power Company";
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpCustomer.Controls.Add(this.radRes);
            this.grpCustomer.Controls.Add(this.radCom);
            this.grpCustomer.Controls.Add(this.radInd);
            this.grpCustomer.Location = new System.Drawing.Point(29, 73);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(183, 199);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Type:";
            // 
            // grpCustBill
            // 
            this.grpCustBill.Controls.Add(this.lblPowerConsumed);
            this.grpCustBill.Controls.Add(this.lblAmountCharged);
            this.grpCustBill.Controls.Add(this.txtChargedAmount);
            this.grpCustBill.Controls.Add(this.txtkWhConsumed);
            this.grpCustBill.Controls.Add(this.txtOffPk_kWh);
            this.grpCustBill.Controls.Add(this.lblOffPk_kWh);
            this.grpCustBill.Controls.Add(this.lblPk_kWh);
            this.grpCustBill.Location = new System.Drawing.Point(246, 73);
            this.grpCustBill.Name = "grpCustBill";
            this.grpCustBill.Size = new System.Drawing.Size(443, 199);
            this.grpCustBill.TabIndex = 1;
            this.grpCustBill.TabStop = false;
            this.grpCustBill.Text = "Customer Bill";
            // 
            // FrmCustomerBill
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 323);
            this.Controls.Add(this.grpCustBill);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.lblCPC);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCustomerBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Energy Bill Calculator";
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpCustBill.ResumeLayout(false);
            this.grpCustBill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtkWhConsumed;
        private System.Windows.Forms.Label lblPowerConsumed;
        private System.Windows.Forms.Label lblAmountCharged;
        private System.Windows.Forms.TextBox txtChargedAmount;
        private System.Windows.Forms.RadioButton radInd;
        private System.Windows.Forms.RadioButton radCom;
        private System.Windows.Forms.RadioButton radRes;
        private System.Windows.Forms.Label lblPk_kWh;
        private System.Windows.Forms.Label lblOffPk_kWh;
        private System.Windows.Forms.TextBox txtOffPk_kWh;
        private System.Windows.Forms.Label lblCPC;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.GroupBox grpCustBill;
    }
}

