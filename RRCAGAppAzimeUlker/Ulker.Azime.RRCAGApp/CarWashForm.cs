using ACE.BIT.ADEV.CarWash;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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
    public partial class CarWashForm : Form
    {
        List<CarWashPackage> packageOptions;
        List<CarWashFragrance> fragranceOptions;
        CarWashInvoice carWashInvoice;
        List<string> interiorServices;
        List<string> exteriorServices;
        CarWashInvoiceForm carWashInvoiceForm;

        private CarWashForm carWashForm;
        private BindingSource carWashSource;


        /// <summary>
        /// Initializes an instance of the CarWashForm class
        /// </summary>
        public CarWashForm()
        {
            InitializeComponent();

            carWashInvoice = new CarWashInvoice(0.07m, 0.05m);
            this.mnuClose.Click += MnuClose_Click;
            this.mnuGenerateInvoice.Click += MnuGenerateInvoice_Click;

            //For carwash invoice form
            this.carWashSource = new BindingSource();
            this.carWashSource.DataSource = carWashInvoice;
            
            //carWashPackage details
            packageOptions = new List<CarWashPackage>();
            CarWashPackage standard = new CarWashPackage("Standard", 7.50m);
            CarWashPackage deluxe = new CarWashPackage("Deluxe", 15.00m);
            CarWashPackage executive = new CarWashPackage("Executive", 35.00m);
            CarWashPackage luxury = new CarWashPackage("Luxury", 55.00m);
            packageOptions.Add(standard);
            packageOptions.Add(deluxe);
            packageOptions.Add(executive);
            packageOptions.Add(luxury);
            this.cboPackage.DisplayMember = "PackageName";

            //carWashFragrance details 
            fragranceOptions = new List<CarWashFragrance>();
            
            //add pine as complimentary fragrance
            CarWashFragrance pine = new CarWashFragrance("Pine", 0.0m);
            fragranceOptions.Add(pine);
       
            //interiorServices details
            interiorServices = new List<string>();
            interiorServices.Add("Fragrance");
            interiorServices.Add("Shampoo Carpets");
            interiorServices.Add("Shampoo Upholstery");
            interiorServices.Add("Interior Protection Coat");
            ////display interior listbox
            //lstInterior.DataSource = fragranceOptions;
            //lstInterior.DisplayMember = "Interior";

            //exteriorServices details
            exteriorServices = new List<string>();
            exteriorServices.Add("Hand Wash");
            exteriorServices.Add("Hand Wax");
            exteriorServices.Add("Wheel Polish");
            exteriorServices.Add("Detail Engine Compartment");
            //display exterior listbox
            //lstExterior.DataSource = packageOptions;
            //lstExterior.DisplayMember = "Exterior";


            //Text file IO
            string filepath  = "fragrances.txt";

            //Creates a FileStream which opens the file with read only access 
            FileStream fileStream;
            fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);

            //Creates a StreamReader which reads text from a FileStream
            StreamReader fileReader;
            fileReader = new StreamReader(fileStream);

            //Creates a collection to store the data read from the file
            //List<CarWashFragrance> fragrances = new List<CarWashFragrance>();

            Console.WriteLine("Reading from{0}...", filepath);

            try
            {
                CarWashFragrance fragrance;

                //Loop while there is more data to read
                while (fileReader.Peek() != -1)
                {
                    //Read a record (line) from the file
                    string record = fileReader.ReadLine();

                    char[] delimiters = { ',' };

                    //Each field is stored as an element in the array
                    string[] fields = record.Split(delimiters);

                    //Array index indicated with an inner Enumeration in the Student class
                    string fragranceName = fields[0];
                    string fragrancePriceString = fields[1];
                    decimal fragrancePrice;
                    Decimal.TryParse(fragrancePriceString, out fragrancePrice);

                    //Create an instance of the data object using the data (fields) read in from the file
                    fragrance = new CarWashFragrance(fragranceName, fragrancePrice);

                    //Add the data object to the collection
                    fragranceOptions.Add(fragrance);
                }

                Console.WriteLine("Reading complete.");
            }
            //IOException occurs when there is an I/O error
            catch(IOException)
            {
                Console.WriteLine("There was an error reading from{0}.", filepath);

            }

            //Closes the StreamReader and the underlying stream
          
            fileReader.Close();

            //Print each data object in the collection
            foreach (CarWashFragrance s in fragranceOptions)
                Console.WriteLine(s);

            this.cboFragrance.DisplayMember = "FragranceName";

            CarWashFormLoad(); 

        }
        /// <summary>
        ///  Handles when user click on Generate Invoice tab,
        ///  the invoice will appear with new dialog window
        /// </summary>
        private void MnuGenerateInvoice_Click(object sender, EventArgs e)
        {
            CarWashInvoiceForm carWashInvoiceForm = new CarWashInvoiceForm(carWashSource);
            carWashInvoiceForm.Show();

            ResetPaymentLabels();

        }

        /// <summary>
        /// Handles when user click on Close tab, car wash form will close.
        /// </summary>
        private void MnuClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        /// <summary>
        /// Helps to load car wash form and display package and fragrance options.
        /// </summary>
        public void CarWashFormLoad()
        {
            //displays package options
            cboPackage.DataSource = packageOptions;
            cboPackage.DisplayMember = "PackageName";
            cboPackage.ValueMember = "PackagePrice";
            
            
            //the package comboBox has no item selected 
            cboPackage.SelectedIndex = -1;

            //displays fragrance options
            cboFragrance.DataSource = fragranceOptions;
            cboFragrance.DisplayMember = "FragranceName";
            cboFragrance.ValueMember = "FragrancePrice";
            //the fragrance comboBox has Pine selected 
            cboFragrance.SelectedIndex = 0;

            //binding subtotal, PST, GST and total
            Binding subtotalBind = new Binding("Text", carWashInvoice, "Subtotal", true);
            subtotalBind.FormatString = "c";
            Binding pstBind = new Binding("Text", carWashInvoice, "ProvincialSalesTaxCharged", true);
            pstBind.FormatString = "N2";
            Binding gstBind = new Binding("Text", carWashInvoice, "GoodsAndServicesTaxCharged", true);
            gstBind.FormatString = "N2";
            Binding totalBind = new Binding("Text", carWashInvoice, "Total", true);
            totalBind.FormatString = "c";

            this.txtSubtotal.DataBindings.Add(subtotalBind);
            this.txtPST.DataBindings.Add(pstBind);
            this.txtGST.DataBindings.Add(gstBind);
            this.lblTotal.DataBindings.Add(totalBind);

            this.cboFragrance.SelectedIndexChanged += CboFragrance_SelectedIndexChanged;
            this.cboPackage.SelectedIndexChanged += CboPackage_SelectedIndexChanged;
        }

        /// <summary>
        /// Handles package comboBox when user select options
        /// </summary>
        private void CboPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
      
            PackageChosen();
            if (cboPackage.SelectedIndex != -1)
            {
                carWashInvoice.PackageCost = (decimal)cboPackage.SelectedValue;
                UpdateOutputUI();
            }
        }

        /// <summary>
        /// Handles fragrance comboBox when user select options
        /// </summary>
        private void CboFragrance_SelectedIndexChanged(object sender, EventArgs e)
        {

            PackageChosen();
            if (cboFragrance.SelectedIndex != -1)
            {
                carWashInvoice.FragranceCost = (decimal)cboFragrance.SelectedValue;
                UpdateOutputUI();

            }
        }

        /// <summary>
        /// Updates the interior list box depending on what package is chosen.
        /// </summary>
        private void PackageChosen()
        {
            List<string> selectedInterior = new List<string>();
            List<string> selectedExterior = new List<string>();

            for (int i = 0; i < ((cboPackage.SelectedIndex) + 1); i++)
            {
                if (i == 0)
                {
                    string fragranceConcat = interiorServices[0] + "-" + ((CarWashFragrance)cboFragrance.SelectedItem).FragranceName;
                    selectedInterior.Add(fragranceConcat);
                    selectedExterior.Add(exteriorServices[i]);
                }
                else
                {
                    selectedInterior.Add(interiorServices[i]);
                    selectedExterior.Add(exteriorServices[i]);
                }
            }

            lstInterior.DataSource = selectedInterior;
            lstExterior.DataSource = selectedExterior;
            lstInterior.DisplayMember = "ToString()";
            lstExterior.DisplayMember = "ToString()";
        }

        /// <summary>
        /// Updates Subtotal, PST, GST and Total sections by take into account
        /// package and fragrance options.
        /// </summary>
        private void UpdateOutputUI()
        {
            if (cboFragrance.SelectedIndex != -1 && cboPackage.SelectedIndex != -1)
            {
                txtSubtotal.DataBindings[0].ReadValue();
                txtPST.DataBindings[0].ReadValue();
                txtGST.DataBindings[0].ReadValue();
                lblTotal.DataBindings[0].ReadValue();    
            }
        }

        /// <summary>
        /// Handles reset all labels to their initial state
        /// </summary>
        private void CarWashForm_Load(object sender, EventArgs e)
        {
     
            ResetPaymentLabels();
        
        }

        /// <summary>
        /// Resets CarWashForm labels to their default state
        /// </summary>
        private void ResetPaymentLabels()
        {
            this.cboPackage.SelectedIndex = -1;
            this.cboFragrance.SelectedIndex = 0;
            this.txtSubtotal.Text = "";
            this.txtPST.Text = "";
            this.txtGST.Text = "";
            this.lblTotal.Text = "";
        }

      
    }
}
