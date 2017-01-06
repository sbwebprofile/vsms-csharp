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
using VSMS.Repo.ViewModel;

namespace VSMS
{
    public partial class AddViewDeleteF : Form
    {
        private VehicleRepo _repository1 = null;
        public static int carid;
        
        public AddViewDeleteF()
        {
            InitializeComponent();
            _repository1 = new VehicleRepo();
            LoadGrid();
            //colorchange();
        }

        private void LoadGrid()
        {

            VehicleDetailsGrid.DataSource = null;
            var list = new BindingList<vehicleViewModel>(_repository1.GetAllViewModel().ToList());
            VehicleDetailsGrid.DataSource = list;
           

        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            AddVehicleInformation av = new AddVehicleInformation();
            av.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeePlanelF ep = new EmployeePlanelF();
            ep.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in VehicleDetailsGrid.SelectedRows)
            {
               
                int rowId = Convert.ToInt32(row.Cells[0].Value);
                string status = Convert.ToString(row.Cells[8].Value);
                if ((rowId > 0) && (status.Equals("Available")))
                {
                    carid = rowId;
                    this.Hide();
                    AddBuyersInformation abi = new AddBuyersInformation();
                    abi.Show();
                }
                else 
                {
                    MessageBox.Show("You can't Sell a Sold Car again! /n Please Check Car Status ", "Car Already Sold! ", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                
                }
            }
        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in VehicleDetailsGrid.SelectedRows)
            {
          
                int rowId = Convert.ToInt32(row.Cells[0].Value);
                if (rowId > 0)
                {
                    _repository1.Delete(rowId);
                    //refresh the :v datagrid
                    VehicleDetailsGrid.Rows.RemoveAt(row.Index);
                }
                //LoadGrid();
            }
        }

        private void AddViewDeleteF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            
            VehicleDetailsGrid.DataSource = null;
            var data = _repository1.GetAllViewModel().Where(a => a.vehicleId.ToString().Contains(searchTextBox.Text) || a.model.Contains(searchTextBox.Text) || a.manufacturer.Contains(searchTextBox.Text) || a.Made_Year.Contains(searchTextBox.Text) || a.status.Contains(searchTextBox.Text) || a.brand.Equals(searchTextBox.Text) || a.chasisNo.Equals(searchTextBox.Text) || a.engineNo.Equals(searchTextBox.Text)).ToList();
            var list = new BindingList<vehicleViewModel>(data);
            VehicleDetailsGrid.DataSource = list;
        }

        private void VehicleDetailsGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewImageColumn image = new DataGridViewImageColumn();
            image = (DataGridViewImageColumn)VehicleDetailsGrid.Columns[9];
            image.ImageLayout = DataGridViewImageCellLayout.Stretch;
            foreach (DataGridViewRow Myrow in VehicleDetailsGrid.Rows)
            {
               
                string status = Convert.ToString(Myrow.Cells[8].Value);
                if (status.Equals("Sold"))
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Orange;
                }
                else
                {
                    Myrow.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void AddViewDeleteF_Load(object sender, EventArgs e)
        {

        }
    }
}
