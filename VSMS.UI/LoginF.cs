using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VSMS.Repo;
using MetroFramework;
using MetroFramework.Forms;

namespace VSMS
{
    public partial class LoginF : Form
    {
       // public Informations info = new Informations();
        //public Operations opr = new Operations();

        //public static bool bv = false;
        private UserRepo _repo = null;
        
        //DataTable dt = new DataTable();
        public LoginF()
        {
            InitializeComponent();
            _repo = new UserRepo();
        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void LoginF_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var count = _repo.IsExist(UserNameTextBox.Text.Trim(), PasswordTextBox.Text.Trim());
            if (count==1)
            {
                this.Hide();
                AdminF af = new AdminF();
                af.Visible = true;
                //bv = true;
            }
            else if (count == 2)
            {
                this.Hide();
                EmployeePlanelF ep = new EmployeePlanelF();
                ep.Visible = true;
                
            }
            else
            {
                
                MessageBox.Show(" User Name Or Password Incorrect ! ", "invalid login credentials", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                
            }
            
            /*       info.userName = UserNameTextBox.Text;
            info.userPass = PasswordTextBox.Text;

          
            dt = opr.login(info);

            if (dt.Rows.Count > 0)
            {
                //dt.Rows[0][4]
                AdminF ad = new AdminF();
                ad.Show();
                //this.Close();
                this.Hide();                

            }
            else 
            {
                MessageBox.Show("Invalid User name or Password !!! ");
            }
           
       */     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ForgetPasswordLabel_Click(object sender, EventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EmployeePlanelF ep = new EmployeePlanelF();
            ep.Show();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void LoginF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
