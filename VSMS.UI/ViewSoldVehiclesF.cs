using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VSMS.Repo;
using VSMS.Repo.ViewModel;


namespace VSMS
{
    public partial class ViewSoldVehiclesF : Form
    {
        private VehicleRepo _repository1 = null;
        private CustomerRepo _repository2 = null;

        
        public static int carid;
        public ViewSoldVehiclesF()

        {
            InitializeComponent();
            _repository1 = new VehicleRepo();
            _repository2=new CustomerRepo();
            LoadGrid();
        }
        private void LoadGrid()
        {

            viewSoldGrid.DataSource = null;
            var list = new BindingList<soldVehicleViewModel>(_repository1.GetSoldView().ToList());
            viewSoldGrid.DataSource = list;
        }
        private void CalculateTotalProfitButton_Click(object sender, EventArgs e)
        {
            int sumB = 0;
            int sumS = 0;
            int profit = 0;
            for (int i = 0; i < viewSoldGrid.Rows.Count; ++i)
            {
                sumB += Convert.ToInt32(viewSoldGrid.Rows[i].Cells[3].Value);
                sumS += Convert.ToInt32(viewSoldGrid.Rows[i].Cells[4].Value);

            }
            profit = sumB - sumS;
            if (profit < 0)
            {
                MessageBox.Show(" Total Cost on buying :    " + sumB + "\n\n Total Cost of Selling  :    " + sumS + "\n\n \t Profit    :  " + -profit);

            }
            else {
                MessageBox.Show(" Total Cost on buying :    " + sumB + "\n\n Total Cost of Selling  :    " + sumS + "\n\n \t Loss    :  " + profit);
           
            }

           // MessageBox.Show(" Total Cost on buying :    "+sumB+"\n\n Total Cost of Selling  :    "+sumS+"\n\n \t Profit    :  "+profit);
           
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeePlanelF EP = new EmployeePlanelF();
            EP.Visible = true;
            
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            viewSoldGrid.DataSource = null;
            var data = _repository1.GetSoldView().Where(a => a.DateSold.ToString().Contains(searchTextBox.Text) || a.CustomerId.ToString().Contains(searchTextBox.Text) || a.CustomerName.Contains(searchTextBox.Text) || a.Mobile.Contains(searchTextBox.Text) || a.Pricesold.ToString().Contains(searchTextBox.Text)).ToList();
           // var data = _repository1.GetSoldView().Where(a => a.DateSold.ToString().Contains(searchTextBox.Text)).ToList();
            
            var list = new BindingList<soldVehicleViewModel>(data);
            viewSoldGrid.DataSource = list;  
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewSoldVehiclesF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
