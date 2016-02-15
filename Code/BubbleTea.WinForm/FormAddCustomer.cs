using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleTea.WinForm
{
    public partial class FormAddCustomer : Form
    {
        public FormAddCustomer()
        {
            InitializeComponent();

            //Bind countrylist
            CountryListcomboBox.DataSource = countryListBindingSource;
            CountryListcomboBox.DisplayMember = "CountryName"; // Column Name
            CountryListcomboBox.ValueMember = "CountryCode";  // Column Name
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customersDataSet.Customers);
            // TODO: This line of code loads data into the 'customersDataSet.CountryList' table. You can move, or remove it, as needed.
            this.countryListTableAdapter.Fill(this.customersDataSet.CountryList);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Save data or call delegate

            try
            {
                CustomersEntities ce = new CustomersEntities();
                ce.Customers.Add(new Customers
                {
                    Firstname = FirstNameTextBox.Text,
                    Lastname = LastNameTextBox.Text,
                    Address = AddressTextBox.Text,
                    CountryCode = (string)CountryListcomboBox.SelectedValue
                });
                ce.SaveChanges();   //Doesn't actually save. Might need to use an adapter or a 'real' SQL server than .mdf

                MessageBox.Show("New customer added (or at least want you to think so)");

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exp)
            {
                //TODO: Validations, and proper error handling
                MessageBox.Show("An error occoured: " + exp.Message);
            }

            
        }
    }
}
