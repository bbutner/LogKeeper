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
            }

            Config.initConnection();
        }

        private void btnAddLog_Click(object sender, EventArgs e)
        {
            if (txtProject.TextLength > 0 && cmbName.Text.Length > 0 && txtLogMessage.Text.Length > 0)
            {
                string name = cmbName.Text.Trim();
                string project = txtProject.Text.Trim();
                string log = txtLogMessage.Text.Trim();
                string timestamp = "";

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

                    txtOutput.Text += timestamp + " #" + project + " | " + name + ": " + log + "\r\n\r\n";

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

                txtOutput.ResetText();

                try
                {
                    while (reader.Read())
                    {
                        txtOutput.Text += reader["timestamp"] + " #" + reader["project"] + " | " + reader["name"].ToString().Trim() + ": " + reader["logmessage"] + "\r\n\r\n";
                    }
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
    }
}
