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
using System.IO;
using System.Drawing.Imaging;

namespace VSMS
{

      public partial class AddVehicleInformation : Form
    {
          private VehicleRepo _repousr1 = null;
          private ComboboxRepo _repousr2 = null;
          
          private string imgpath = null;
                
          public AddVehicleInformation()
        {
            InitializeComponent();
            _repousr1=  new VehicleRepo();
            _repousr2 = new ComboboxRepo();
            HomeButton.Visible = false;
            EditButton.Visible = false;
            ConfirmButton.Visible = false;            
            LoadComboBox();
        }

          private void LoadComboBox()
          {


              var listofmodel = _repousr2.GetAll().ToList();
              var listofmodel2 = _repousr2.GetAll().ToList();

              modelCombobox.DataSource = listofmodel;
              modelCombobox.DisplayMember = "vehiclebrand";
              modelCombobox.ValueMember = "vvvid";

              manufacturerCombobox.DataSource = listofmodel2;
              manufacturerCombobox.DisplayMember = "vehiclemanufacturar";
              manufacturerCombobox.ValueMember = "vvvid";
               
              
          }
          
       
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            HomeButton.Visible = true;
            EditButton.Visible = true;
            ConfirmButton.Visible = true;
            BackButton.Visible = false;
            ResetButton.Visible = false;
            NextButton.Visible = false;
            Model.Enabled = false;
            ChasisNo.Enabled = false;
            ManufactureYear.Enabled = false;
            Color.Enabled = false;
            Engine.Enabled = false;
            BuyingPriceTextBox.Enabled = false;
            manufacturerCombobox.Enabled = false;
            modelCombobox.Enabled = false;
        }

        private void Manufacturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddVehicleInformation_Load(object sender, EventArgs e)
        {

        }

        private void Model_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChasisNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Brand_TextChanged(object sender, EventArgs e)
        {

        }

        private void VehicleID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManufactureYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void Color_TextChanged(object sender, EventArgs e)
        {

        }

        private void Engine_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Model.Text) || string.IsNullOrEmpty(BuyingPriceTextBox.Text) || string.IsNullOrEmpty(ChasisNo.Text) || string.IsNullOrEmpty(ManufactureYear.Text) || string.IsNullOrEmpty(Color.Text) || string.IsNullOrEmpty(Engine.Text))
            {
                MessageBox.Show("Insufficient Information \n Please Fill-up all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            else
            {               
                 try
                {   
                    int check = Convert.ToInt32(BuyingPriceTextBox.Text);

                      
                try
                {
                    var vehicleregister = new vehicle
                    {   
                        model = Model.Text.Trim(),
                        chasisNo = ChasisNo.Text.Trim(),
                        brand = modelCombobox.Text,
                        manufacturer = manufacturerCombobox.Text,
                        mYear = ManufactureYear.Text.Trim(),
                        color = Color.Text.Trim(),
                        engineNo = Engine.Text.Trim(),
                        bprice=Int32.Parse(BuyingPriceTextBox.Text.Trim()),
                        image= CnvtimgToByte(imgpath),
                        //image= imgpath,
                        status = "Available"
                        //id = Int32.Parse(id_tbox.Text.Trim())

                    };
                    _repousr1.Create(vehicleregister);

                    MessageBox.Show("Vehicle Successfully Added to the Database !!");
                    this.Visible = false;
                    AddViewDeleteF avd = new AddViewDeleteF();
                    avd.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                }
                 catch (Exception h)
                 {
                     MessageBox.Show("Please provide number Input for Amount !");
                     
                 }
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            HomeButton.Visible = false;
            EditButton.Visible = false;
            ResetButton.Visible = true;
            ConfirmButton.Visible = false;
            BackButton.Visible = true;
            modelCombobox.Enabled = true;
            manufacturerCombobox.Enabled = true;
           
            NextButton.Visible = true;
            Model.Enabled = true;
            ChasisNo.Enabled = true;
            
            ManufactureYear.Enabled = true;
            Color.Enabled = true;
            Engine.Enabled = true;
            BuyingPriceTextBox.Enabled = true;
        }

        private void AddVehicleInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AddViewDeleteF adf = new AddViewDeleteF();
            adf.Visible = true;
            this.Visible = false;
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
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
           
            
        }
        private static byte[] CnvtimgToByte(string fileName)
        {
            Bitmap bitMap = new Bitmap(fileName);
            ImageFormat bmpFormat = bitMap.RawFormat;
            var imageToConvert = Image.FromFile(fileName);
            using (MemoryStream ms = new MemoryStream())
            {
                imageToConvert.Save(ms, bmpFormat);
                return ms.ToArray();
            }
        }  

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();             
            opf.Filter = "Type Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";             
            if (opf.ShowDialog() == DialogResult.OK)             
            {                 
                //pictureBox1.Image = Image.FromFile(opf.FileName);
                pictureBox1.ImageLocation=opf.FileName;
             
                if (opf.CheckFileExists)
                {
                   
                    //string paths= Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                   // File.Copy(opf.FileName, paths + "\\Images\\" + ChasisNo.Text + ".jpg");
                    //imgpath = "\\Images\\" + ChasisNo.Text + ".jpg";
                   imgpath = opf.FileName;
                  // MessageBox.Show(imgpath);
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
