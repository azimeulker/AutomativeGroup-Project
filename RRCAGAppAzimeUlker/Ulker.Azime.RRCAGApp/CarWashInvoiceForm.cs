using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ulker.Azime.Business;

/**
 * Name: Azime Ulker
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-03-25
 */
namespace Ulker.Azime.RRCAGApp
{

    /// <summary>
    /// Represents Car Wash Form with data binding
    /// </summary>
    public class CarWashInvoiceForm : ACE.BIT.ADEV.Forms.CarWashInvoiceForm
    {

        private BindingSource carWashInvoice;

        /// <summary>
        /// Initialize an instance of CarWashInvoice form with BindingSource paramater
        /// </summary>
        public CarWashInvoiceForm(BindingSource carWashInvoice)
        {
            // step 1
            this.carWashInvoice = carWashInvoice;
            //this.carWashInvoice.DataSource = carWashInvoice;

            this.Load += CarWashInvoiceForm_Load;
   
        }
        /// <summary>
        /// Handles bind data which are package price, fragrance price, subtotal, GST, PST
        /// and Total
        /// </summary>
        private void CarWashInvoiceForm_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            Binding packagePriceBind = new Binding("Text", carWashInvoice, "PackageCost", true);
            Binding fragrancePriceBind = new Binding("Text", carWashInvoice, "FragranceCost", true);
            Binding subtotalInvoiceBind = new Binding("Text", carWashInvoice, "Subtotal", true);
            Binding GSTBind = new Binding("Text", carWashInvoice, "GoodsAndServicesTaxCharged", true);
            Binding PSTBind = new Binding("Text", carWashInvoice, "GoodsAndServicesTaxCharged", true);
            Binding totalBind = new Binding("Text", carWashInvoice, "Total", true);
            packagePriceBind.FormatString = "c";
            fragrancePriceBind.FormatString = "N2";
            subtotalInvoiceBind.FormatString = "N2";
            GSTBind.FormatString = "N2";
            totalBind.FormatString = "c";


            this.lblPackagePrice.DataBindings.Add(packagePriceBind);
            this.lblFragrancePrice.DataBindings.Add(fragrancePriceBind);
            this.lblSubtotal.DataBindings.Add(subtotalInvoiceBind);
            this.lblGoodsAndServicesTax.DataBindings.Add(GSTBind);
            this.lblProvincialSalesTax.DataBindings.Add(PSTBind);
            this.lblTotal.DataBindings.Add(totalBind);
        }
    }
}
