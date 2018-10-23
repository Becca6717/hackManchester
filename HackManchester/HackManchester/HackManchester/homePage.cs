using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackManchester
{
    public partial class homePage : Form
    {
        
        public homePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            dtLabel.Text = dt.ToString();

        }

        private void sunriseTimeLbl_Click(object sender, EventArgs e)
        {

        }

        private void sunriseLbl_Click(object sender, EventArgs e)
        {

        }

        private void sunsetTimeLbl_Click(object sender, EventArgs e)
        {

        }

        private void sunsetLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
