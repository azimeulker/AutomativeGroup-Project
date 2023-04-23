using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Text;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using ACE.BIT.ADEV.Forms;
/*
* Name: Azime Ulker
* Program: Business Information Technology
* Course: ADEV-2008 Programming 2
* Created: 2023.04.12
*/
namespace Ulker.Azime.RRCAGApp
{
    internal class VehicleDataForm : ACE.BIT.ADEV.Forms.VehicleDataForm
    {
        OleDbDataAdapter dataAdapter;
        DataSet dataSet;
        BindingSource bindingSource;
     


        /// <summary>
        /// Creates an instance of a vehicle data form
        /// </summary>
        public VehicleDataForm()
        {
            InitializeComponent();

            this.mnuFileClose.Click += MnuFileClose_Click;
            this.Load += VehicleDataForm_Load;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AllowUserToResizeRows = false;
            this.mnuEditDelete.Enabled = false;
            this.FormClosing += VehicleDataForm_FormClosing;
            this.dgvVehicles.SelectionChanged += DgvVehicles_SelectionChanged;
            this.dgvVehicles.CellValueChanged += DgvVehicles_CellValueChanged;
            this.mnuEditDelete.Click += MnuEditDelete_Click;
            this.mnuFileSave.Click += MnuFileSave_Click;
            mnuEditDelete.Enabled = false;

            VehicleDataFormLoad();


        }

        /// <summary>
        /// When the user clicks save on the menu, the database will update.
        /// </summary>
        private void MnuFileSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while saving the changes to the vehicle data.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// When the user clicks delete on the menu, selected row will be deleted.
        /// </summary>
        private void MnuEditDelete_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Are you sure you want to permanently delete stock item?", "Delete Stock Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (x.Equals(DialogResult.Yes))
            {
                try
                {
                    dgvVehicles.Rows.Remove(dgvVehicles.SelectedRows[0]);
                    //dgvVehicles.Rows.RemoveAt(0);
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred when deleting the selected vehicle.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bindingSource.EndEdit();
                mnuEditDelete.Enabled = false;
            }
        }

        /// <summary>
        /// When a cell's value changes, the save function in the menu is enabled
        /// and the form's title is changed to indicate data has been changed.
        /// </summary>
        private void DgvVehicles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.Text = "* Vehicle Data";
            this.mnuFileSave.Enabled = true;
        }

        /// <summary>
        /// When the selection on the data grid view changes and is not a new row or the selected current row, the
        /// delete function on the menu is enabled.
        /// </summary>
        private void DgvVehicles_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVehicles.CurrentRow.Selected || !dgvVehicles.CurrentRow.IsNewRow)
            {
                mnuEditDelete.Enabled = true;
                dgvVehicles.EndEdit();
            }
            else
            {
                mnuEditDelete.Enabled = false;
            }
        }

        /// <summary>
        /// if the form is closing but has changes made to the data, the user is prompted to save the changes.
        /// </summary>
        private void VehicleDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if data has changes
            if (dataSet.HasChanges())
            {
                DialogResult x = MessageBox.Show("Do you wish to save the changes?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                if (x.Equals(DialogResult.Yes))
                {
                    try
                    {
                        SaveData();
                    }
                    catch(Exception)
                    {
                        DialogResult d = MessageBox.Show("An error occurred while saving the changes to the vehicle data. Do you still wish to close this window?",
                        "Save Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                        if(d.Equals(DialogResult.No))
                        {
                            e.Cancel = true;
                        }
                    }
                }
                else if (x.Equals(DialogResult.Cancel))
                {
                    e.Cancel = true;
                }

            }
        }

        /// <summary>
        /// Saves the data and resets the form's title back to it's initial state and disables the save menu item.
        /// </summary>
        private void SaveData()
        {
            dgvVehicles.EndEdit();
            bindingSource.EndEdit();
            mnuFileSave.Enabled = false;
            this.Text = "Vehicle Data";
            dataAdapter.Update(dataSet, "VehicleStock");
        }

        ///// <summary>
        ///// When the form loads, the VehicleDataFormLoad method is called.
        ///// </summary>
        private void VehicleDataForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.VehicleDataFormLoad();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to load vehicle data.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        /// <summary>
        ///  When the user clicks the close item on the menu, close the form.
        /// </summary>
        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /// <summary>
        /// Creates connection to the database, populates the data grid view with database data
        /// and hides the ID column of the database.
        /// </summary>
        private void VehicleDataFormLoad()
        {
            mnuFileSave.Enabled = false;

            //Opening connection to the database
            OleDbConnection dbConnection = new OleDbConnection();
            dbConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AMDatabase.mdb";
            dbConnection.Open();

            //Connecting DBCommand to the connection object and selecting data using DBCommand
            OleDbCommand dbCommand = new OleDbCommand();
            dbCommand.Connection = dbConnection;
            dbCommand.CommandText = "SELECT * FROM VehicleStock";

            //Using DataAdapter to connect to Command object and filling dataset, connect commandBuilder object to dataAdabter
            dataAdapter = new OleDbDataAdapter();
            dataAdapter.SelectCommand = dbCommand;
            OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder();
            commandBuilder.DataAdapter = dataAdapter;
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "VehicleStock");

            //Connecting BindingSource object to data tables
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataSet.Tables["VehicleStock"];
            dgvVehicles.DataSource = bindingSource;
            dgvVehicles.Columns["ID"].Visible = false;
        }


        /// <summary>
        /// Represents designer code which created automatically
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // VehicleDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(949, 518);
            this.Name = "VehicleDataForm";
            this.Text = "Vehicle Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
