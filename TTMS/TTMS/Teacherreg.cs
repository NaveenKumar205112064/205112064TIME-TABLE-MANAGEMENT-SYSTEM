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
    public partial class TREG : Form
    {


        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        public TREG()
        {
            InitializeComponent();
        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            if (TID.Text!= "" & FNAME.Text != "" & LNAME.Text != "" & QUALI.Text != "" & EMAIL.Text != "" & MOB.Text != "" & PASS.Text != "")
            {
                com.Connection = con;
                com.CommandText = "insert into tprofile(TID,FNAME,LNAME,QUALI,EMAIL,MOB,PASS) values ('" + TID.Text + "','" + FNAME.Text + "','" + LNAME.Text + "','" + QUALI.Text + "','" + EMAIL.Text + "','" + MOB.Text + "','" + PASS.Text + "')";
                com.ExecuteNonQuery();
                com.Dispose();
                MessageBox.Show("record inserted");
                TID.Text = "";
                FNAME.Text = "";
                LNAME.Text = "";
                QUALI.Text = "";
                EMAIL.Text = "";
                MOB.Text = "";
                PASS.Text = "";
                main f = new main();
                f.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("Plzzz insert all entries ");
            }

        }

        private void TREG_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "PROVIDER=MSDAORA; USER ID=system; PASSWORD=naveen; Unicode=true;";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                 //   MessageBox.Show("Connection Success");
                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void RES_Click(object sender, EventArgs e)
        {
            TID.Text = ""; 
            FNAME.Text = "";
            LNAME.Text = "";
            QUALI.Text = "";
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

        private void PASS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
