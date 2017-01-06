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
    public partial class AddUserF : Form
    {

        private UserRepo _repousr = null;

        public AddUserF()
        {
            InitializeComponent();
            _repousr = new UserRepo();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(UserPasswordTextBox.Text) || string.IsNullOrEmpty(ConfirmPassTextBox.Text) || string.IsNullOrEmpty(UserTypeComboBox.Text) || string.IsNullOrEmpty(SecurityQuestionComboBox.Text) || string.IsNullOrEmpty(SequrityAnsTextBox.Text))
            {
                MessageBox.Show("Insufficient Information \n Please Fill-up all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   
                if(UserPasswordTextBox.Text.Equals(ConfirmPassTextBox.Text))
                {

                    try
                    {
                        var userregister = new user
                        {
                            userName = UsernameTextBox.Text.Trim(),
                            userPass = UserPasswordTextBox.Text.Trim(),
                            userType = UserTypeComboBox.SelectedItem.ToString(),
                            sQuestion = SecurityQuestionComboBox.SelectedItem.ToString(),
                            aQuestion = SequrityAnsTextBox.Text.Trim()
                            //id = Int32.Parse(id_tbox.Text.Trim())

                        };
                        _repousr.Create(userregister);

                        MessageBox.Show("Successfully Inserted!!");
                        this.Visible = false;
                        AdminF af = new AdminF();
                        af.Visible = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Username Already Taken!! Choose another username !", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //For triangle Warning
                    }
               
                }
                else
                {
                    MessageBox.Show("Password Mismatch!!");

                }
            }
        }

        private void AddUserF_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddUserF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminF af = new AdminF();
            af.Visible = true;
        }
    }
}
