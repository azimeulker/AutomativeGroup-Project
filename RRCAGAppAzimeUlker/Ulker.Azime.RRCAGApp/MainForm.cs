//using ACE.BIT.ADEV.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




/**
 * Name: Azime Ulker
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-03-11
 */

namespace Ulker.Azime.RRCAGApp
{
    /// <summary>
    /// Represents the main form used for RRC Automotive Library classes
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes an instance of the MainForm class with the design
        /// and event subscriptions.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            this.msFileExit.Click += MsFileExit_Click;
            this.msHelpAbout.Click += MsHelpAbout_Click;
            this.msFileOpenSalesQuote.Click += MsFileOpenSalesQuote_Click;
            this.msFileOpenCarWash.Click += MsFileOpenCarWash_Click;
            this.msDataVehicles.Click += MsDataVehicles_Click;
        }

        /// <summary>
        /// Handles the click event of the Vehicle Data Form
        /// </summary>
        private void MsDataVehicles_Click(object sender, EventArgs e)
        {
            VehicleDataForm vehicleDataForm = new VehicleDataForm();
            vehicleDataForm.MdiParent = this;
            vehicleDataForm.Show();
        }

        /// <summary>
        /// Handles the Click event of the Car Wash Form
        /// </summary>
        private void MsFileOpenCarWash_Click(object sender, EventArgs e)
        {
            CarWashForm form;
            form = new CarWashForm();
            form.MdiParent = this;
            form.Show();
        }

        /// <summary>
        /// Handles the Click event of the Sales Quote Form.
        /// </summary>
        private void MsFileOpenSalesQuote_Click(object sender, EventArgs e)
        {
            SalesQuoteForm form;

            form = new SalesQuoteForm();
            form.MdiParent = this;
            form.Show();
        }


        /// <summary>
        /// Handles the Click event of the about menu item.
        /// </summary>
        private void MsHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm form;

            form = new AboutForm();

            //make the form appear
            form.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the exit menu item.
        /// </summary>
        private void MsFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       


    }

}
