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
    public partial class TT_MCA5 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;

        string sem;


        public void passvalue(string str)
        {
            sem = str;
        }

        public TT_MCA5()
        {
            InitializeComponent();
        }

        private void TT_MCA5_Load(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            data5.DataSource = null;
            try
            {

                //System.Data.OleDb.OleDbConnection MyCnn;

                System.Data.DataSet DSet;
                //     '" + sem + "'
                System.Data.OleDb.OleDbDataAdapter MyCmd;
                MyCmd = new System.Data.OleDb.OleDbDataAdapter("select * from mca5 ", con);
                MyCmd.TableMappings.Add("Table", "mca5");
                DSet = new System.Data.DataSet();

                MyCmd.Fill(DSet);

                data5.DataSource = DSet.Tables[0];
                MyCmd.Dispose();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOME f = new HOME();
            f.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            course f = new course();
            f.Show();
            Hide();
        }
    }
}
