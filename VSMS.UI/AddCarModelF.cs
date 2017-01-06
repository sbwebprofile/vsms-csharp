using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSMS.Entity;
using VSMS.Repo;


namespace VSMS.UI
{
    public partial class AddCarModelF : Form
    {
        private ComboboxRepo _repousr1 = null;
        public AddCarModelF()
        {
            _repousr1 = new ComboboxRepo();
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try { 
                if (string.IsNullOrEmpty(newManufacturarTextBox.Text) || string.IsNullOrEmpty(newModelTextBox.Text))
                {
                    MessageBox.Show("Insufficient Information \n Please Fill-up Both Model & Manufacturer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var modelregister = new comboboxdata
                    {
                        vehiclebrand = newModelTextBox.Text.Trim(),
                        vehiclemanufacturar = newManufacturarTextBox.Text.Trim()

                    };
                    _repousr1.Create(modelregister);
                    MessageBox.Show("New Model & Manufacturar Added to the Database !!");
                    this.Hide();
                }
        }
            catch{
                MessageBox.Show("Model or Manufacturer already exists in Database, \n Please Choose another model or manufacturar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }
    }
}
