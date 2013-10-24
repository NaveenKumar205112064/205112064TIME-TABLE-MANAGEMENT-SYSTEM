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
    public partial class VIEW_TEACHER_DATABASE : Form
    {

        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        public VIEW_TEACHER_DATABASE()
        {
            InitializeComponent();
        }

        private void VIEW_TEACHER_DATABASE_Load(object sender, EventArgs e)
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

            datat.DataSource = null;
            try
            {

                //System.Data.OleDb.OleDbConnection MyCnn;

                System.Data.DataSet DSet;

                System.Data.OleDb.OleDbDataAdapter MyCmd;


                MyCmd = new System.Data.OleDb.OleDbDataAdapter("select * from  tprofile ", con);

                MyCmd.TableMappings.Add("Table", "tprofile");

                DSet = new System.Data.DataSet();

                MyCmd.Fill(DSet);

                datat.DataSource = DSet.Tables[0];

                //                con.Close();
                MyCmd.Dispose();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacher_menu f = new teacher_menu();
            f.Show();
            Hide();
                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void datat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
