using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;
using Ulker.Azime.Business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/**
 * Name: Azime Ulker
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-03-11
 */

namespace Ulker.Azime.RRCAGApp
{
    /// <summary>
    /// Represents the form used for Vehicle Sales Quote Form calculation.
    /// </summary>
    public partial class SalesQuoteForm : Form
    {
        private Accessories accessoriesSelectedByUser;
        private ExteriorFinish exteriorFinishSelectedByUser;

        //better practice to use constants
        private const decimal provincialSalesTaxRate = .07m;
        private const decimal goodsAndServicesTaxRate = .05m;

        //declare SalesQuote as private field to access throughout the class.
        private SalesQuote salesQuote;

        /// <summary>
        /// Initialized an instance of the SalesQuoteForm class with the design
        /// and event subscriptions.
        /// </summary>
        public SalesQuoteForm()
        {
            InitializeComponent();

            //subscribe events
            btnCalculateQuote.Click += BtnCalculateQuote_Click;
            grpAccessories.Click += GrpAccessoriesAndExterior_Click;
            this.nudNumberOfYears.ValueChanged += NudNumberOfYears_ValueChanged;
            this.nudAnnualInterestRate.ValueChanged += NudNumberOfYears_ValueChanged;
            this.txtVehicleSalePrice.TextChanged += TxtVehicleSalePrice_TextChanged;
            this.txtTradeInValue.TextChanged += TxtVehicleSalePrice_TextChanged;
            this.btnReset.Click += BtnReset_Click;
            this.chkStereoSystem.CheckedChanged += CheckBoxAndRadio_CheckedChanged;
            this.chkLeatherInterior.CheckedChanged += CheckBoxAndRadio_CheckedChanged;
            this.chkComputerNavigation.CheckedChanged += CheckBoxAndRadio_CheckedChanged;
            this.radStandard.CheckedChanged += CheckBoxAndRadio_CheckedChanged;
            this.radPearlized.CheckedChanged += CheckBoxAndRadio_CheckedChanged;
            this.radCustomized.CheckedChanged += CheckBoxAndRadio_CheckedChanged;

        }

        /// <summary>
        /// Handles when the accessories checkboxes and finish radio buttons are changed. If the SalesQuoteForm
        /// object is not null, a new quote is generated. The summary and financing labels are populated with the new information.
        /// </summary>
        private void CheckBoxAndRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (salesQuote != null)
            {
                CheckFinishesAndAccessories();
                GenerateVehicleSalesQuote();
                PopulateQuote();
                FinanceCalculator();

            }
        }

        /// <summary>
        /// Handles when reset button clicked. A dialog box is shown, asking the user if they
        /// want to reset the form.
        /// </summary>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to reset the form?", "Reset Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dialogResult.Equals(DialogResult.Yes))
            {
                ResetSalesQuoteForm();
            }
        }

        /// <summary>
        /// Method called when the vehicle sale price textbox or trade-in amount textbox are changed. The summary and payment fields are reset and 
        /// the SalesQuoteForm object is set to null.
        /// </summary>
        private void TxtVehicleSalePrice_TextChanged(object sender, EventArgs e)
        {
            ResetSummaryAndPaymentFields();
            salesQuote = null;
        }

        /// <summary>
        /// Method called when the numerical up/down for interest or years is changed. Runs financial calculator to update labels.
        /// </summary>
        private void NudNumberOfYears_ValueChanged(object sender, EventArgs e)
        {
            FinanceCalculator();
        }

        /// <summary>
        /// Handles the chosen accessories to calculate for option section.
        /// </summary>
        private void GrpAccessoriesAndExterior_Click(object sender, EventArgs e)
        {

            decimal sumOptions;


        }

        private void CheckFinishesAndAccessories()
        {

            //Check boxes for accessories selected

            if (chkStereoSystem.Checked)
                accessoriesSelectedByUser = Accessories.StereoSystem;

            if (chkLeatherInterior.Checked)
                accessoriesSelectedByUser = Accessories.LeatherInterior;

            if (chkStereoSystem.Checked)
                accessoriesSelectedByUser = Accessories.StereoSystem;

            if (chkStereoSystem.Checked && chkLeatherInterior.Checked)
                accessoriesSelectedByUser = Accessories.StereoAndLeather;

            if (chkStereoSystem.Checked && chkComputerNavigation.Checked)
                accessoriesSelectedByUser = Accessories.StereoAndNavigation;

            if (chkLeatherInterior.Checked && chkComputerNavigation.Checked)
                accessoriesSelectedByUser = Accessories.LeatherAndNavigation;

            if (chkStereoSystem.Checked && chkLeatherInterior.Checked && chkComputerNavigation.Checked)
                accessoriesSelectedByUser = Accessories.All;

            if (!chkStereoSystem.Checked && !chkLeatherInterior.Checked && !chkComputerNavigation.Checked)
                accessoriesSelectedByUser = Accessories.None;
          


            //Exterior finish selected by user
            if (radStandard.Checked)
                exteriorFinishSelectedByUser = ExteriorFinish.Standard;

            if (radPearlized.Checked)
                exteriorFinishSelectedByUser = ExteriorFinish.Pearlized;

            if (radCustomized.Checked)
                exteriorFinishSelectedByUser = ExteriorFinish.Custom;

   
        }

        /// <summary>
        /// Handles when "Calculate Quote" button is clicked.
        /// Also handles trade-in value error messages without conflict with vehicle's sale price's error messages.
        /// </summary>
        private void BtnCalculateQuote_Click(object sender, EventArgs e)
        {

            GenerateVehicleSalesQuote();

            bool hasError = false;
            decimal vehicleSalePriceInput = 0;
            decimal tradeInValueInput = 0;

            // display error when the trade-in value input is less than zero
            if (string.IsNullOrEmpty(this.txtTradeInValue.Text))
            {
                errorProvider.SetError(txtTradeInValue, "Trade-in value is a required field.");
                hasError = true;

            }

            // display error when trade-in value input is not numeric
            try
            {
                if (!hasError)
                {
                    tradeInValueInput = decimal.Parse(this.txtTradeInValue.Text);
                }

            }
            catch (FormatException)
            {
                errorProvider.SetError(txtTradeInValue, "Trade-in value cannot contain letters or special characters.");
                hasError = true;
            }


            //display error when trade-in value is less than zero

            if (!hasError)
            {
                tradeInValueInput = decimal.Parse(this.txtTradeInValue.Text);
                if (tradeInValueInput < 0)
                {
                    errorProvider.SetError(txtTradeInValue, "Trade-in value cannot be less than zero");
                    hasError = true;
                }
            }

        }

        /// <summary>
        /// Handles and validates user information, and create error messages
        /// </summary>
        private void GenerateVehicleSalesQuote()
        {
            bool hasError = false;
            decimal vehicleSalePriceInput = 0;
            decimal tradeInValueInput = 0;

            //Vehicle's Sale Price Error Messages

            errorProvider.Clear();

            //display error when there is no input in vehicle's sale price text box
            if (string.IsNullOrEmpty(this.txtVehicleSalePrice.Text))
            {
                errorProvider.SetError(txtVehicleSalePrice, "Vehicle price is a required field.");
                hasError = true;
            }

            //display error when vehicle's sale price is not numeric
            try
            {
                //if statements prevents the parse from failing if the textbox is empty.
                if (!hasError)
                {
                    vehicleSalePriceInput = decimal.Parse(this.txtVehicleSalePrice.Text);
                }

            }
            catch (FormatException)
            {
                errorProvider.SetError(txtVehicleSalePrice, "Vehicle price cannot contain letters or special characters.");
                hasError = true;
            }

            //display error when the vehicle's sale price input is less than or equal to zero

            if (!hasError)
            {
                vehicleSalePriceInput = decimal.Parse(this.txtVehicleSalePrice.Text);
                if (vehicleSalePriceInput <= 0)
                {
                    errorProvider.SetError(txtVehicleSalePrice, "Vehicle Price cannot be less than or equal to zero.");
                    hasError = true;
                }
            }


            //display error when trade-in value is greater than the vehicle sale price.

            if (!hasError)
            {
                tradeInValueInput = decimal.Parse(this.txtTradeInValue.Text);

                if (tradeInValueInput > vehicleSalePriceInput)
                {
                    errorProvider.SetError(txtTradeInValue, "Trade-in value cannot exceed the vehicle sale price");
                    hasError = true;
                }

            }

            // If both inputs have errors, display an error icon for each text boxes.
            if (hasError)
            {
                // Display an error icon to the right of the text boxes with a padding of 3
                //the icon will nor blink
                errorProvider.SetIconPadding(txtVehicleSalePrice, 3);
                errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                errorProvider.SetIconPadding(txtTradeInValue, 3);
                errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            }

            //added else block to prevent this from executing if validation fails
            else
            {
                CheckFinishesAndAccessories();

                salesQuote = new SalesQuote(decimal.Parse(txtVehicleSalePrice.Text),
                              decimal.Parse(txtTradeInValue.Text), provincialSalesTaxRate + goodsAndServicesTaxRate, accessoriesSelectedByUser, exteriorFinishSelectedByUser);


                PopulateQuote();
                FinanceCalculator();

            }
        }

        /// <summary>
        /// Populates the summary text boxes and labels according to values calculated based on the SalesQuote object.
        /// </summary>
        private void PopulateQuote()
        {

            txtSumVehicleSalePrice.Text = String.Format("{0:C}", salesQuote.VehicleSalePrice);
            txtOptions.Text = String.Format("{0:N2}", salesQuote.AccessoryCost + salesQuote.FinishCost);
            txtSubtotal.Text = String.Format("{0:C}", salesQuote.SubTotal);
            txtSalesTax.Text = String.Format("{0:N2}", salesQuote.SalesTax);
            txtTotal.Text = String.Format("{0:C}", salesQuote.SubTotal + salesQuote.SalesTax);
            txtSumTradeIn.Text = String.Format("{0:N2}", -(salesQuote.TradeInAmount));
            //lblAmountDue.Text = String.Format("{0:C}", (salesQuote.Total - salesQuote.TradeInAmount));
            lblAmountDue.Text = String.Format("{0:C}", salesQuote.AmountDue);

        }

        /// <summary>
        /// Handles Finance calculation with using finance group box
        /// </summary>
        private void FinanceCalculator()
        {
            if (salesQuote != null)

                lblMonthlyPayment.Text = String.Format("{0:C}", Financial.GetPayment((nudAnnualInterestRate.Value / 1200m),
                                                                (((int)nudNumberOfYears.Value) * 12), salesQuote.AmountDue));

        }
        /// <summary>
        /// Resets the summary and payment field labels to their default state only.
        /// </summary>
        private void ResetSummaryAndPaymentFields()
        {
            txtSumVehicleSalePrice.Text = "";
            txtOptions.Text = "";
            txtSubtotal.Text = "";
            txtSalesTax.Text = "";
            txtSumTradeIn.Text = "";
            txtTotal.Text = "";
            lblAmountDue.Text = "";
            lblMonthlyPayment.Text = "";
        }

        /// <summary>
        /// Resets SalesQuoteForm labels to their default state.
        /// </summary>
        protected void ResetSalesQuoteForm()
        {
            ResetSummaryAndPaymentFields();
    
        }
    }
}