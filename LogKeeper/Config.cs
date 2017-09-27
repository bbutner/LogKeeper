using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogKeeper
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private string sqlDB;
        private string sqlUser;
        private string sqlPass;
        private string conString;

        private void btnSQLConnect_Click(object sender, EventArgs e)
        {
            if (txtSQLPass.TextLength == 0 || txtSQLUser.TextLength == 0 || cmbInstances.Text.Length == 0)
            {
                MessageBox.Show("Please enter all fields!");
            } else
            {
                sqlDB = cmbInstances.Text;
                sqlUser = txtSQLUser.Text;
                sqlPass = txtSQLPass.Text;

                conString = "Data Source=" + sqlDB + ";Initial Catalog = LogKeeper; User ID = " + sqlUser + "; Password = " + sqlPass;

                SqlConnection connection = new SqlConnection(conString);

                try
                {
                    connection.Open();
                    connection.Close();

                    MessageBox.Show("Connected!");

                    StreamWriter cfgFile = new StreamWriter(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Config.txt");
                    cfgFile.WriteLine("DBSERVER=" + cmbInstances.Text);
                    cfgFile.WriteLine("USER=" + txtSQLUser.Text);
                    cfgFile.WriteLine("PASS=" + txtSQLPass.Text);

                    cfgFile.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not connect to SQL Server!");
                }
            }
        }

        private void cmbInstances_Click(object sender, EventArgs e)
        {
            if (cmbInstances.Items.Count == 0)
            {
                DataTable instances = SqlDataSourceEnumerator.Instance.GetDataSources();

                if (instances.Rows.Count > 0)
                {
                    for (int i = 0; i < instances.Rows.Count; i++)
                    {
                        cmbInstances.Items.Add(instances.Rows[i]["ServerName"].ToString() + "\\" + instances.Rows[i]["InstanceName"].ToString());
                    }
                } else
                {
                    MessageBox.Show("Couldn't load instances.");
                }
            }
        }
    }
}
