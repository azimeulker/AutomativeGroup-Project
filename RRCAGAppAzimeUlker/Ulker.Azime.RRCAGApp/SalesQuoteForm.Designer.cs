namespace Ulker.Azime.RRCAGApp
{
    partial class SalesQuoteForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVehicleSalePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTradeInValue = new System.Windows.Forms.TextBox();
            this.chkStereoSystem = new System.Windows.Forms.CheckBox();
            this.chkLeatherInterior = new System.Windows.Forms.CheckBox();
            this.chkComputerNavigation = new System.Windows.Forms.CheckBox();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.radPearlized = new System.Windows.Forms.RadioButton();
            this.radCustomized = new System.Windows.Forms.RadioButton();
            this.grpExteriorFinish = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSumVehicleSalePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOptions = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSumTradeIn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.nudNumberOfYears = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nudAnnualInterestRate = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.grpFinance = new System.Windows.Forms.GroupBox();
            this.btnCalculateQuote = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAccessories.SuspendLayout();
            this.grpExteriorFinish.SuspendLayout();
            this.grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).BeginInit();
            this.grpFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle\'s Sale Price:";
            // 
            // txtVehicleSalePrice
            // 
            this.txtVehicleSalePrice.Location = new System.Drawing.Point(163, 37);
            this.txtVehicleSalePrice.Name = "txtVehicleSalePrice";
            this.txtVehicleSalePrice.Size = new System.Drawing.Size(128, 22);
            this.txtVehicleSalePrice.TabIndex = 1;
            this.txtVehicleSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trade-in Value:";
            // 
            // txtTradeInValue
            // 
            this.txtTradeInValue.Location = new System.Drawing.Point(163, 74);
            this.txtTradeInValue.Name = "txtTradeInValue";
            this.txtTradeInValue.Size = new System.Drawing.Size(128, 22);
            this.txtTradeInValue.TabIndex = 3;
            this.txtTradeInValue.Text = "0";
            this.txtTradeInValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkStereoSystem
            // 
            this.chkStereoSystem.AutoSize = true;
            this.chkStereoSystem.Location = new System.Drawing.Point(25, 31);
            this.chkStereoSystem.Name = "chkStereoSystem";
            this.chkStereoSystem.Size = new System.Drawing.Size(117, 20);
            this.chkStereoSystem.TabIndex = 4;
            this.chkStereoSystem.Text = "Stereo System";
            this.chkStereoSystem.UseVisualStyleBackColor = true;
            // 
            // chkLeatherInterior
            // 
            this.chkLeatherInterior.AutoSize = true;
            this.chkLeatherInterior.Location = new System.Drawing.Point(25, 72);
            this.chkLeatherInterior.Name = "chkLeatherInterior";
            this.chkLeatherInterior.Size = new System.Drawing.Size(117, 20);
            this.chkLeatherInterior.TabIndex = 5;
            this.chkLeatherInterior.Text = "Leather Interior";
            this.chkLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // chkComputerNavigation
            // 
            this.chkComputerNavigation.AutoSize = true;
            this.chkComputerNavigation.Location = new System.Drawing.Point(25, 113);
            this.chkComputerNavigation.Name = "chkComputerNavigation";
            this.chkComputerNavigation.Size = new System.Drawing.Size(155, 20);
            this.chkComputerNavigation.TabIndex = 6;
            this.chkComputerNavigation.Text = "Computer Navigation";
            this.chkComputerNavigation.UseVisualStyleBackColor = true;
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.chkComputerNavigation);
            this.grpAccessories.Controls.Add(this.chkLeatherInterior);
            this.grpAccessories.Controls.Add(this.chkStereoSystem);
            this.grpAccessories.Location = new System.Drawing.Point(32, 137);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Size = new System.Drawing.Size(254, 174);
            this.grpAccessories.TabIndex = 7;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Checked = true;
            this.radStandard.Location = new System.Drawing.Point(28, 34);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(83, 20);
            this.radStandard.TabIndex = 8;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // radPearlized
            // 
            this.radPearlized.AutoSize = true;
            this.radPearlized.Location = new System.Drawing.Point(28, 75);
            this.radPearlized.Name = "radPearlized";
            this.radPearlized.Size = new System.Drawing.Size(85, 20);
            this.radPearlized.TabIndex = 9;
            this.radPearlized.Text = "Pearlized";
            this.radPearlized.UseVisualStyleBackColor = true;
            // 
            // radCustomized
            // 
            this.radCustomized.AutoSize = true;
            this.radCustomized.Location = new System.Drawing.Point(28, 116);
            this.radCustomized.Name = "radCustomized";
            this.radCustomized.Size = new System.Drawing.Size(154, 20);
            this.radCustomized.TabIndex = 10;
            this.radCustomized.Text = "Customized Detailing";
            this.radCustomized.UseVisualStyleBackColor = true;
            // 
            // grpExteriorFinish
            // 
            this.grpExteriorFinish.Controls.Add(this.radCustomized);
            this.grpExteriorFinish.Controls.Add(this.radPearlized);
            this.grpExteriorFinish.Controls.Add(this.radStandard);
            this.grpExteriorFinish.Location = new System.Drawing.Point(32, 352);
            this.grpExteriorFinish.Name = "grpExteriorFinish";
            this.grpExteriorFinish.Size = new System.Drawing.Size(254, 174);
            this.grpExteriorFinish.TabIndex = 11;
            this.grpExteriorFinish.TabStop = false;
            this.grpExteriorFinish.Text = "Exterior Finish";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vehicle\'s Sale Price:";
            // 
            // txtSumVehicleSalePrice
            // 
            this.txtSumVehicleSalePrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSumVehicleSalePrice.Location = new System.Drawing.Point(187, 34);
            this.txtSumVehicleSalePrice.Name = "txtSumVehicleSalePrice";
            this.txtSumVehicleSalePrice.Size = new System.Drawing.Size(128, 22);
            this.txtSumVehicleSalePrice.TabIndex = 13;
            this.txtSumVehicleSalePrice.TabStop = false;
            this.txtSumVehicleSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Options:";
            // 
            // txtOptions
            // 
            this.txtOptions.Location = new System.Drawing.Point(187, 80);
            this.txtOptions.Name = "txtOptions";
            this.txtOptions.Size = new System.Drawing.Size(128, 22);
            this.txtOptions.TabIndex = 15;
            this.txtOptions.TabStop = false;
            this.txtOptions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(187, 120);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(128, 22);
            this.txtSubtotal.TabIndex = 17;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sales Tax (12%):";
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(187, 164);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.Size = new System.Drawing.Size(128, 22);
            this.txtSalesTax.TabIndex = 19;
            this.txtSalesTax.TabStop = false;
            this.txtSalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(187, 201);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(128, 22);
            this.txtTotal.TabIndex = 21;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Trade-in:";
            // 
            // txtSumTradeIn
            // 
            this.txtSumTradeIn.Location = new System.Drawing.Point(187, 244);
            this.txtSumTradeIn.Name = "txtSumTradeIn";
            this.txtSumTradeIn.Size = new System.Drawing.Size(128, 22);
            this.txtSumTradeIn.TabIndex = 23;
            this.txtSumTradeIn.TabStop = false;
            this.txtSumTradeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Amount Due:";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmountDue.Location = new System.Drawing.Point(187, 288);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(128, 22);
            this.lblAmountDue.TabIndex = 25;
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblAmountDue);
            this.grpSummary.Controls.Add(this.label9);
            this.grpSummary.Controls.Add(this.txtSumTradeIn);
            this.grpSummary.Controls.Add(this.label8);
            this.grpSummary.Controls.Add(this.txtTotal);
            this.grpSummary.Controls.Add(this.label7);
            this.grpSummary.Controls.Add(this.txtSalesTax);
            this.grpSummary.Controls.Add(this.label6);
            this.grpSummary.Controls.Add(this.txtSubtotal);
            this.grpSummary.Controls.Add(this.label5);
            this.grpSummary.Controls.Add(this.txtOptions);
            this.grpSummary.Controls.Add(this.label4);
            this.grpSummary.Controls.Add(this.txtSumVehicleSalePrice);
            this.grpSummary.Controls.Add(this.label3);
            this.grpSummary.Location = new System.Drawing.Point(344, 28);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(359, 361);
            this.grpSummary.TabIndex = 26;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // nudNumberOfYears
            // 
            this.nudNumberOfYears.Location = new System.Drawing.Point(20, 77);
            this.nudNumberOfYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumberOfYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfYears.Name = "nudNumberOfYears";
            this.nudNumberOfYears.Size = new System.Drawing.Size(80, 22);
            this.nudNumberOfYears.TabIndex = 27;
            this.nudNumberOfYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "No. Of Years";
            // 
            // nudAnnualInterestRate
            // 
            this.nudAnnualInterestRate.DecimalPlaces = 2;
            this.nudAnnualInterestRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudAnnualInterestRate.Location = new System.Drawing.Point(123, 78);
            this.nudAnnualInterestRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudAnnualInterestRate.Name = "nudAnnualInterestRate";
            this.nudAnnualInterestRate.Size = new System.Drawing.Size(79, 22);
            this.nudAnnualInterestRate.TabIndex = 29;
            this.nudAnnualInterestRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(126, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 40);
            this.label12.TabIndex = 30;
            this.label12.Text = "Annual Interest Rate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(229, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "Monthly Payment";
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(232, 77);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(106, 23);
            this.lblMonthlyPayment.TabIndex = 32;
            this.lblMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpFinance
            // 
            this.grpFinance.Controls.Add(this.lblMonthlyPayment);
            this.grpFinance.Controls.Add(this.label13);
            this.grpFinance.Controls.Add(this.label12);
            this.grpFinance.Controls.Add(this.nudAnnualInterestRate);
            this.grpFinance.Controls.Add(this.label11);
            this.grpFinance.Controls.Add(this.nudNumberOfYears);
            this.grpFinance.Location = new System.Drawing.Point(344, 396);
            this.grpFinance.Name = "grpFinance";
            this.grpFinance.Size = new System.Drawing.Size(363, 130);
            this.grpFinance.TabIndex = 33;
            this.grpFinance.TabStop = false;
            this.grpFinance.Text = "Finance";
            // 
            // btnCalculateQuote
            // 
            this.btnCalculateQuote.Location = new System.Drawing.Point(558, 547);
            this.btnCalculateQuote.Name = "btnCalculateQuote";
            this.btnCalculateQuote.Size = new System.Drawing.Size(149, 40);
            this.btnCalculateQuote.TabIndex = 34;
            this.btnCalculateQuote.Text = "Calculate Quote";
            this.btnCalculateQuote.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(32, 547);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 40);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // SalesQuoteForm
            // 
            this.AcceptButton = this.btnCalculateQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 604);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculateQuote);
            this.Controls.Add(this.grpFinance);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpExteriorFinish);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.txtTradeInValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVehicleSalePrice);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SalesQuoteForm";
            this.Text = "Vehicle Sales Quote";
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.grpExteriorFinish.ResumeLayout(false);
            this.grpExteriorFinish.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).EndInit();
            this.grpFinance.ResumeLayout(false);
            this.grpFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVehicleSalePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTradeInValue;
        private System.Windows.Forms.CheckBox chkStereoSystem;
        private System.Windows.Forms.CheckBox chkLeatherInterior;
        private System.Windows.Forms.CheckBox chkComputerNavigation;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.RadioButton radPearlized;
        private System.Windows.Forms.RadioButton radCustomized;
        private System.Windows.Forms.GroupBox grpExteriorFinish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSumVehicleSalePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOptions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSumTradeIn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.NumericUpDown nudNumberOfYears;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudAnnualInterestRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.GroupBox grpFinance;
        private System.Windows.Forms.Button btnCalculateQuote;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}