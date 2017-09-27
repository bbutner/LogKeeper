namespace LogKeeper
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnAddLog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowConfig = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearchProjects = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtLogMessage = new System.Windows.Forms.TextBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.DataGridView();
            this.colProj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddLog
            // 
            this.btnAddLog.Location = new System.Drawing.Point(232, 562);
            this.btnAddLog.Name = "btnAddLog";
            this.btnAddLog.Size = new System.Drawing.Size(170, 37);
            this.btnAddLog.TabIndex = 0;
            this.btnAddLog.Text = "Add Log";
            this.btnAddLog.UseVisualStyleBackColor = true;
            this.btnAddLog.Click += new System.EventHandler(this.btnAddLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowConfig);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSearchProjects);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.txtLogMessage);
            this.groupBox1.Controls.Add(this.cmbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProject);
            this.groupBox1.Controls.Add(this.btnAddLog);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 605);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnShowConfig
            // 
            this.btnShowConfig.Location = new System.Drawing.Point(512, 59);
            this.btnShowConfig.Name = "btnShowConfig";
            this.btnShowConfig.Size = new System.Drawing.Size(113, 27);
            this.btnShowConfig.TabIndex = 10;
            this.btnShowConfig.Text = "Config";
            this.btnShowConfig.UseVisualStyleBackColor = true;
            this.btnShowConfig.Click += new System.EventHandler(this.btnShowConfig_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(512, 16);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 27);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearchProjects
            // 
            this.btnSearchProjects.Location = new System.Drawing.Point(253, 18);
            this.btnSearchProjects.Name = "btnSearchProjects";
            this.btnSearchProjects.Size = new System.Drawing.Size(21, 22);
            this.btnSearchProjects.TabIndex = 7;
            this.btnSearchProjects.Text = "?";
            this.btnSearchProjects.UseVisualStyleBackColor = true;
            this.btnSearchProjects.Click += new System.EventHandler(this.btnSearchProjects_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(280, 16);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 27);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtLogMessage
            // 
            this.txtLogMessage.Location = new System.Drawing.Point(9, 100);
            this.txtLogMessage.Multiline = true;
            this.txtLogMessage.Name = "txtLogMessage";
            this.txtLogMessage.Size = new System.Drawing.Size(616, 456);
            this.txtLogMessage.TabIndex = 5;
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Items.AddRange(new object[] {
            "Beau"});
            this.cmbName.Location = new System.Drawing.Point(67, 63);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(186, 21);
            this.cmbName.TabIndex = 4;
            this.cmbName.Click += new System.EventHandler(this.cmbName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project:";
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(67, 19);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(186, 20);
            this.txtProject.TabIndex = 1;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(1360, 573);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(113, 37);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.AllowUserToAddRows = false;
            this.txtOutput.AllowUserToDeleteRows = false;
            this.txtOutput.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.txtOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.txtOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProj,
            this.colName,
            this.colLog,
            this.colTime});
            this.txtOutput.Location = new System.Drawing.Point(652, 11);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.RowHeadersVisible = false;
            this.txtOutput.Size = new System.Drawing.Size(821, 550);
            this.txtOutput.TabIndex = 9;
            this.txtOutput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.txtOutput_CellContentClick);
            // 
            // colProj
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colProj.DefaultCellStyle = dataGridViewCellStyle1;
            this.colProj.FillWeight = 60F;
            this.colProj.HeaderText = "Project";
            this.colProj.Name = "colProj";
            this.colProj.ReadOnly = true;
            this.colProj.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colName
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colName.FillWeight = 110.6774F;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colLog
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colLog.DefaultCellStyle = dataGridViewCellStyle3;
            this.colLog.FillWeight = 21.08025F;
            this.colLog.HeaderText = "Log";
            this.colLog.Name = "colLog";
            this.colLog.ReadOnly = true;
            this.colLog.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colLog.Width = 472;
            // 
            // colTime
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTime.FillWeight = 203.0457F;
            this.colTime.HeaderText = "Timestamp";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTime.Width = 146;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 622);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Log Keeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.TextBox txtLogMessage;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSearchProjects;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnShowConfig;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView txtOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
    }
}

