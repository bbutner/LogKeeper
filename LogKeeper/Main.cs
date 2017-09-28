﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogKeeper
{
    public partial class Main : Form
    {
        private string lastProject= "";
        private int timeColWidth;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Config.txt"))
            {
                Config cfg = new Config();
                cfg.ShowDialog();

                if (!File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "/Config.txt"))
                {
                    this.Close();
                }
                else 
                {
                    Config.initConnection();
                }
            } 
            else 
            {
                Config.initConnection();
                timeColWidth = txtOutput.Columns["colProj"].Width;
            }
        }

        private void btnAddLog_Click(object sender, EventArgs e)
        {
            if (txtProject.TextLength > 0 && cmbName.Text.Length > 0 && txtLogMessage.Text.Length > 0)
            {
                string name = cmbName.Text.Trim();
                string project = txtProject.Text.Trim();
                string log = txtLogMessage.Text.Trim();
                string timestamp = "";

                if (lastProject.Length == 0)
                {
                    lastProject = project;
                }

                if (lastProject != project)
                {
                    txtOutput.ResetText();
                    lastProject = project;
                }

                SqlConnection tempCon = Config.getSQLCon();

                try
                {
                    string sqlInsert = "INSERT INTO Logs(name, logmessage, timestamp, project) VALUES('" + name + "','" + log + "',GETDATE(),'" + project + "')";

                    tempCon.Open();

                    SqlCommand insertLog = new SqlCommand(sqlInsert, tempCon);
                    SqlDataReader insert = insertLog.ExecuteReader();
                    insert.Close();

                    string sqlTime = "SELECT GETDATE() as time";
                    SqlCommand getTimestamp = new SqlCommand(sqlTime, tempCon);
                    SqlDataReader reader = getTimestamp.ExecuteReader();

                    while (reader.Read())
                    {
                        timestamp = reader["time"].ToString();
                    }

                    reader.Close();

                    txtOutput.Rows.Add(new[] {project, name, log, timestamp });

                    tempCon.Close();

                    txtLogMessage.ResetText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding your log!");
                    Console.WriteLine(ex);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (txtProject.Text.Length > 0)
            {
                SqlConnection tempCon = Config.getSQLCon();

                tempCon.Open();
                string sqlLoad = "SELECT * FROM logs WHERE project='" + txtProject.Text + "'";
                SqlCommand loadLogs = new SqlCommand(sqlLoad, tempCon);
                SqlDataReader reader = loadLogs.ExecuteReader();

                txtOutput.Rows.Clear();

                try
                {
                    while (reader.Read())
                    {
                        txtOutput.Rows.Add(new[] { reader["project"].ToString().Trim(), reader["name"].ToString().Trim(), reader["logmessage"].ToString(), reader["timestamp"].ToString() });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    reader.Close();
                    tempCon.Close();
                }
            }
            else
            {
                MessageBox.Show("Please provide a project name.");
            }
        }

        private void cmbName_Click(object sender, EventArgs e)
        {
            if (txtProject.Text.Length > 0)
            {
                btnLoad.PerformClick();
            }
        }

        private void btnSearchProjects_Click(object sender, EventArgs e)
        {
            ProjectSearch projSearch = new ProjectSearch();
            projSearch.ShowDialog();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtOutput.Rows.Count > 1)
            {
                string copy = "";

                if (chkNoTime.Checked)
                {
                    foreach (DataGridViewRow row in txtOutput.Rows)
                    {
                        copy += "#" + row.Cells["colProj"].Value + " | " + row.Cells["colName"].Value + ": " + row.Cells["colLog"].Value + "\r\n\r\n";
                    }

                    Clipboard.SetText(copy);
                }
                else
                {
                    foreach (DataGridViewRow row in txtOutput.Rows)
                    {
                        copy += row.Cells["colTime"].Value + " #" + row.Cells["colProj"].Value + " | " + row.Cells["colName"].Value + ": " + row.Cells["colLog"].Value + "\r\n\r\n";
                    }

                    Clipboard.SetText(copy);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtProject.ResetText();
            txtLogMessage.ResetText();
            txtOutput.Rows.Clear();
            cmbName.Text = "";
        }

        private void btnShowConfig_Click(object sender, EventArgs e)
        {
            Config cfg = new Config();
            cfg.ShowDialog();
        }

        private void txtOutput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtOutput.Rows.Count > 0) {
                int row = txtOutput.CurrentCell.RowIndex;
                int col = txtOutput.CurrentCell.ColumnIndex;

                Clipboard.SetText(txtOutput.Rows[row].Cells[col].Value.ToString());
            }
        }

        private void chkNoTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoTime.Checked)
            {
                txtOutput.Columns["colLog"].Width = txtOutput.Columns["colLog"].Width + timeColWidth;
                txtOutput.Columns["colTime"].Width = 0;
            } else
            {
                txtOutput.Columns["colTime"].Width = timeColWidth;
                txtOutput.Columns["colLog"].Width = txtOutput.Columns["colLog"].Width - timeColWidth;
            }
        }
    }
}
