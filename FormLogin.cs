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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        loginDBDataContext test = new loginDBDataContext();
        private void button_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_username.Text) || string.IsNullOrEmpty(textBox_pass.Text))
            {
                MessageBox.Show("Please provide your Username and Password!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_username.Select();
                return;
            }
            try
            {
                var q = test.LOGINs.Where(user => user.Username == textBox_username.Text && user.Password == textBox_pass.Text).First();
                //var q = (from p in test.LOGINs
                //             where p.Username == textBox_username.Text && p.Password == textBox_pass.Text select p).First();

                Form1 a = new Form1();
                this.Visible = false; //ẩn thôi chứ khum tắt
                a.ShowDialog();
                this.Visible = true; //mở lại
            }
            catch (Exception)
            {

                MessageBox.Show("Please check your Username and Password again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_username.Select();
                return;

            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void label_forgot_Click(object sender, EventArgs e)
        {
            FormForgotPassword a = new FormForgotPassword();
            this.Visible = false;
            a.ShowDialog();
            this.Visible = true;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            //TopMost = true;
        }
    }
}
