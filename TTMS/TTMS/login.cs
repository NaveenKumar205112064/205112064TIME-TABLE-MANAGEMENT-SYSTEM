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
    public partial class HOME : Form
    {

        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;

        public HOME()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "PROVIDER=MSDAORA; USER ID=system; PASSWORD=naveen; Unicode=true;";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
               //     MessageBox.Show("Connection Success");
                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
          /*  main f = new main();
            f.Show();
            Hide();
*/      
        }

        private void button1_Click(object sender, EventArgs e)
        {

            main f = new main();
            f.Show();
            Hide();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            Int64 count;
            Int64 reg;
    //        MessageBox.Show(TEACH.Text);
     //       MessageBox.Show(STUD.Text);
            if (UNAME.Text != "" & PASS.Text != "" & PROF.Text == "STUDENT")
            {
                com.Connection = con;
                com.CommandText = "select RNO  from sprofile where PASS= '" + PASS.Text + "' ";
                reg = Convert.ToInt64(UNAME.Text);
                count = Convert.ToInt64(com.ExecuteScalar());
             
                if (count == reg)
                {
                    course f = new course();
                    f.Show();
                    Hide();
                }
                else
                    MessageBox.Show("wrong password or username");
            }
            else
                if (UNAME.Text != "" & PASS.Text != "" & PROF.Text == "TEACHER")
                {
                    com.Connection = con;
                    com.CommandText = "select TID  from tprofile where PASS= '" + PASS.Text + "' ";
                    count = Convert.ToInt32(com.ExecuteScalar());
                     reg = Convert.ToInt32(UNAME.Text);
                    if (count == reg)
                    {
                        teacher_menu f = new teacher_menu();
                        f.Show();
                        Hide();
                    }
                    else
                        MessageBox.Show("wrong TEACHER ID OR PASSWORD");
                }
            else
                    MessageBox.Show("FILL ALL VALUES");

            UNAME.Text = "";
            PASS.Text = "";
            PROF.Text = "";
        }

        private void TEACH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();

        }
    }
}
