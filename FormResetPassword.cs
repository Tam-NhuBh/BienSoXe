using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BienSoXe
{
    public partial class FormResetPassword : Form
    {
        public FormResetPassword()
        {
            InitializeComponent();
        }
        loginDBDataContext test = new loginDBDataContext();
        string emailForgot = FormForgotPassword.to;
        private void button_reset_Click(object sender, EventArgs e)
        {
            if (textBox_newpass.Text == textBox_confirm.Text)
            {

                var pass = (from user in test.LOGINs where user.Email == emailForgot select user).ToList(); 
                pass[0].Password = textBox_newpass.Text;
                test.SubmitChanges();
                MessageBox.Show("Reset successfully!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The new password do not match so enter the same password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
