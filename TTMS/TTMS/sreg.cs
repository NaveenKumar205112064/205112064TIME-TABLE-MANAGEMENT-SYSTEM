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


    public partial class sreg : Form
    {

        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        Int64 count;
        public sreg()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            if (FNAME.Text != "" & LNAME.Text != "" & RNO.Text != "" & COURSE.Text != "" & EMAIL.Text != "" & MOB.Text != "" & PASS.Text != "" )
            {
                com.Connection = con;
                com.CommandText = "insert into sprofile(FNAME,LNAME,RNO,COURSE,EMAIL,MOB,PASS) values ('" + FNAME.Text + "','" + LNAME.Text + "','" + RNO.Text + "','" + COURSE.Text + "','" + EMAIL.Text + "','" + MOB.Text + "','" + PASS.Text + "')";
                com.ExecuteNonQuery();
                com.Dispose();
                MessageBox.Show("record inserted");
                FNAME.Text = "";
                LNAME.Text = "";
                RNO.Text = "";
                COURSE.Text = "" ;
                EMAIL.Text = "" ;
                MOB.Text = "" ;
                PASS.Text = "";

            }
            else
            {
                MessageBox.Show("Plzzz insert all entries ");
            }

        }

        private void first_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "PROVIDER=MSDAORA; USER ID=system; PASSWORD=naveen; Unicode=true;";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                //    MessageBox.Show("Connection Success");
                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void RES_Click(object sender, EventArgs e)
        {
            FNAME.Text = "";
            LNAME.Text = "";
            RNO.Text = "";
            COURSE.Text = "";
            EMAIL.Text = "";
            MOB.Text = "";
            PASS.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            Hide();
        }
    }
}
