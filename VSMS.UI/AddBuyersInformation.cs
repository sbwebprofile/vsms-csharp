using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VSMS.Repo;
using VSMS.Entity;


namespace VSMS
{
    public partial class AddBuyersInformation : Form
    {
        private CustomerRepo _repousr2 = null;
        private VehicleRepo _repousr3 = null;
        
        
        public AddBuyersInformation()
        {
            InitializeComponent();
            
                PaymentTypeComboBox.SelectedIndex = 0;
                _repousr2 = new CustomerRepo();
                _repousr3= new VehicleRepo();
                VehicleIdTextBox.Text = AddViewDeleteF.carid.ToString();
                VehicleIdTextBox.Enabled = false;
                InvoiceDatePicker.Value = DateTime.Today;
                WstartDatePicker.Value = DateTime.Today;
                WendDatePicker.Value = DateTime.Today;
           
                 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AddBuyersInformation_Load(object sender, EventArgs e)
        {

       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstNameTextbox.Text)|| string.IsNullOrEmpty(AmountTextBox.Text) || string.IsNullOrEmpty(LastNameTextBox.Text) || string.IsNullOrEmpty(MobileNoTextBox.Text) || string.IsNullOrEmpty(EmailTextbox.Text) || string.IsNullOrEmpty(AddressTextBox.Text) || string.IsNullOrEmpty(InsuranceCoTextBox.Text) || string.IsNullOrEmpty(InsIDTextbox.Text) || string.IsNullOrEmpty(VehicleIdTextBox.Text) )
            {
                    MessageBox.Show("Insufficient Information \n Please Fill-up all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
            else
            {
                try
                {
                    int temp = Convert.ToInt32(AmountTextBox.Text);


                    try
                    {
                        var customerRegister = new customer
                        {

                            fName = FirstNameTextbox.Text.Trim(),
                            lName = LastNameTextBox.Text.Trim(),
                            mobile = MobileNoTextBox.Text.Trim(),
                            email = EmailTextbox.Text.Trim(),
                            address = AddressTextBox.Text.Trim(),
                            insuranceCompany = InsuranceCoTextBox.Text.Trim(),
                            insuranceId = InsIDTextbox.Text.Trim(),
                            invoiceDate = InvoiceDatePicker.Value.Date,
                            warrentyS = WstartDatePicker.Value.Date,
                            warrentyE = WendDatePicker.Value.Date,
                            vehicleId = Int32.Parse(VehicleIdTextBox.Text),
                            paymentType = PaymentTypeComboBox.SelectedItem.ToString()

                        };
                        _repousr2.Create(customerRegister);
                        int id_of_car = AddViewDeleteF.carid;
                        int sellPrice = Int32.Parse(AmountTextBox.Text.Trim());
                        _repousr3.Update(id_of_car, sellPrice);

                        MessageBox.Show("Provided Informations Successfully Inserted!!");
                        this.Visible = false;
                        ViewSoldVehiclesF vsv = new ViewSoldVehiclesF();
                        vsv.Visible = true;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());

                    }
                }
                catch (Exception h)
                {
                    MessageBox.Show("Please provide number Input for Amount");
                }


            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddBuyersInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void ProccedButton_Click(object sender, EventArgs e)
        {
           
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
                  
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private void DisableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = true;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddViewDeleteF avd = new AddViewDeleteF();
            avd.Show();
        }


    }
}
