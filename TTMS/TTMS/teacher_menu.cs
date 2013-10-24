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
    public partial class teacher_menu : Form
    {
        public teacher_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VIEW_STUDENT_RECORD f = new VIEW_STUDENT_RECORD();
            f.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           VIEW_TEACHER_DATABASE f = new VIEW_TEACHER_DATABASE();
            f.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HOME f = new HOME();
            f.Show();
            Hide();
                    
        }

        private void teacher_menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            course f = new course();
            f.Show();
            Hide();
        }
    }
}
