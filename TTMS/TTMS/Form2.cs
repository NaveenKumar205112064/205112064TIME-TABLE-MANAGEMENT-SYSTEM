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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void STUD_Click(object sender, EventArgs e)
        {

           
            sreg   f = new sreg();
            f.Show();
            Hide();
        }

        private void TEACH_Click(object sender, EventArgs e)
        {

            TREG f = new TREG();
            f.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main f = new main();
            f.Show();
            Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
