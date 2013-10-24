using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TTMS
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            HOME f = new HOME();
            f.Show();
            Hide();
        }

        private void NEWREG_Click(object sender, EventArgs e)
        {
            sreg f = new sreg();
            f.Show();
            Hide();
        }

        private void NEWREG_Click_1(object sender, EventArgs e)
        {

            Form2 f = new Form2();
            f.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
