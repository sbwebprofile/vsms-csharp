using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VSMS.UI;

namespace VSMS
{
    public partial class EmployeePlanelF : Form
    {
        public EmployeePlanelF()
        {    
            InitializeComponent();
            BackToAdminButton.Visible = false;
            ExitButton.Location = new Point(76, 242);
        }
        public EmployeePlanelF(int a) {
            InitializeComponent();
            
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            AddViewDeleteF avd = new AddViewDeleteF();
            avd.Show();
            
        }

        private void ChooseAction_Click(object sender, EventArgs e)
        {

        }

        private void ViewSoldVehiclesButton_Click(object sender, EventArgs e)
        {
            Hide();
            ViewSoldVehiclesF vsv = new ViewSoldVehiclesF();
            vsv.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackToAdminButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminF af = new AdminF();
            af.Visible = true;

        }

        private void EmployeePlanelF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SellVehicleButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
            AddCarModelF ac = new AddCarModelF();
            ac.Visible = true;
            
            

        }
    }
}
