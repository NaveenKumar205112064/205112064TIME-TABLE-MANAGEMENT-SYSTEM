using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace TTMS
{
    public partial class course : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;

        public course()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = sem.Text;
            if (str == "mca1")
            {
                TT_MCA1 ob = new TT_MCA1();
                ob.passvalue(str);
                ob.Show();
                Hide();
            }
            else if (str == "mca3")
            {
                TT_MCA3 f = new TT_MCA3();
                f.passvalue(str);
                f.Show();
                Hide();
            
            }
            else if (str == "mca5")
            {
                TT_MCA5 f = new TT_MCA5();
                f.passvalue(str);
                f.Show();
                Hide();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string val = com.SelectedItem + "";
           // MessageBox.Show(val);

        }

        private void course_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "PROVIDER=MSDAORA; USER ID=system; PASSWORD=naveen; Unicode=true;";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                   // MessageBox.Show("Connection Success");
                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HOME f = new HOME();
            f.Show();
            Hide();
        }
    }
}
