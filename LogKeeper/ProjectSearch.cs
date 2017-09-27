using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogKeeper
{
    public partial class ProjectSearch : Form
    {
        public ProjectSearch()
        {
            InitializeComponent();
        }

        private void ProjectSearch_Load(object sender, EventArgs e)
        {
            SqlConnection tempCon = Config.getSQLCon();

            string sqlProj = "SELECT project FROM logs GROUP BY project";

            tempCon.Open();

            SqlCommand loadProj = new SqlCommand(sqlProj, tempCon);
            SqlDataReader projects = loadProj.ExecuteReader();

            lstProjects.View = View.Details;

            try
            {
                while (projects.Read())
                {
                    lstProjects.Items.Add(projects["project"].ToString());
                }
            }
            finally
            {
                projects.Close();
                tempCon.Close();
            }
        }
    }
}
