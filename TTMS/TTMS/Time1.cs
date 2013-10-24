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
    public partial class Time1 : Form
    {

        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr1;
        public Time1()
        {
            InitializeComponent();
        }


         private void Time1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1264;PASSWORD=User145;Data Source=nitt;";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                    MessageBox.Show("Connection Success");
                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
         }
        private void SUBMIT_Click(object sender, EventArgs e)
        {

            if (DAY.Text != "" )
            {
                com.Connection = con;
                com.CommandText = "select *  from MCA1 where DAY='" + DAY.Text + "' ";
                  dr1 = com.ExecuteReader();
                  if (dr1.Read())
                  {
                      MessageBox.Show("data has been read");
                      /*        DAY.Text = " ";
                              DAY.Enabled = false;
                              SUBMIT.Text = " ";
                              SUBMIT.Enabled = false;

                              string count0 = Convert.ToString(dr.GetString(2));
                              SUBCODE.Text = count0;
                        */
                  }
                  else
                  {
                      MessageBox.Show("opppsss");
                  }
            }
            else
            {
                MessageBox.Show("Plzzz insert all entries ");
            }
        }

       
        }
    }

