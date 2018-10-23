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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            //titleLbl.Parent = pictureBox1;
            titleLbl.BackColor = Color.Transparent;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {

        }

    
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hp = new HomePage();
            hp.ShowDialog();
        }

        private void emailLbl_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
