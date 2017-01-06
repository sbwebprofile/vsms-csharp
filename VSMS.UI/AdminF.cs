using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VSMS
{
    public partial class AdminF : Form
    {
        public AdminF()
        {
            InitializeComponent();
        }

        private void AdminF_Load(object sender, EventArgs e)
        {

        }

        private void ManageEmployeesB_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddUserF af = new AddUserF(); 
            af.Visible = true;
        }

        private void ManageVehicles_Click(object sender, EventArgs e)
        {
            Hide();
            EmployeePlanelF em = new EmployeePlanelF(5);
           
            em.Show();
        }

        private void AdminF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void EXITB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
