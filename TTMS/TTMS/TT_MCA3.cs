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
    public partial class TT_MCA3 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;

        string sem;


        public void passvalue(string str)
        {
            sem = str;
        }
        public TT_MCA3()
        {
            InitializeComponent();
        }

        private void TT_MCA3_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            data3.DataSource = null;
            try
            {

                //System.Data.OleDb.OleDbConnection MyCnn;

                System.Data.DataSet DSet;
                //     '" + sem + "'
                System.Data.OleDb.OleDbDataAdapter MyCmd;
                MyCmd = new System.Data.OleDb.OleDbDataAdapter("select * from mca3 ", con);
                MyCmd.TableMappings.Add("Table", "mca3");
                DSet = new System.Data.DataSet();

                MyCmd.Fill(DSet);

                data3.DataSource = DSet.Tables[0];
                MyCmd.Dispose();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            course f = new course();
            f.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOME f = new HOME();
            f.Show();
            Hide();
        }
    }
}
