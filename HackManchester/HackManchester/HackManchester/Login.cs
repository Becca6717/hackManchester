using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackManchester
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            titleLbl.BackColor = Color.Transparent;
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hp = new HomePage();
            hp.ShowDialog();
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                emailValidationLbl.Text = "You must enter an email";
            }

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                passwordValidationLbl.Text = "You must enter a password";
            }
        }
    }
}
