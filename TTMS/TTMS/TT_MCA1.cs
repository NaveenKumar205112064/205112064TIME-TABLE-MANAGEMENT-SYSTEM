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
    public partial class TT_MCA1 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;

         string sem;


        public void passvalue(string str)
        {
            sem = str;
        }

        public TT_MCA1()
        {
            InitializeComponent();
        }

        private void time_table_Load(object sender, EventArgs e)
        {
            //
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

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.DataSource = null;
            try
            {

                //System.Data.OleDb.OleDbConnection MyCnn;

                System.Data.DataSet DSet;
           //     '" + sem + "'
                System.Data.OleDb.OleDbDataAdapter MyCmd;
                MyCmd = new System.Data.OleDb.OleDbDataAdapter("select * from mca1 ", con);
                MyCmd.TableMappings.Add("Table", "mca1");
                DSet = new System.Data.DataSet();

                MyCmd.Fill(DSet);

                data.DataSource = DSet.Tables[0];
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

        private void button3_Click(object sender, EventArgs e)
        {
            HOME f = new HOME();
            f.Show();
            Hide();
        }
    }
}