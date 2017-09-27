namespace LogKeeper
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSQLUser = new System.Windows.Forms.TextBox();
            this.txtSQLPass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbInstances = new System.Windows.Forms.ComboBox();
            this.btnSQLConnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQL User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SQL Pass:";
            // 
            // txtSQLUser
            // 
            this.txtSQLUser.Location = new System.Drawing.Point(113, 15);
            this.txtSQLUser.Name = "txtSQLUser";
            this.txtSQLUser.Size = new System.Drawing.Size(202, 20);
            this.txtSQLUser.TabIndex = 2;
            // 
            // txtSQLPass
            // 
            this.txtSQLPass.Location = new System.Drawing.Point(113, 53);
            this.txtSQLPass.Name = "txtSQLPass";
            this.txtSQLPass.PasswordChar = '*';
            this.txtSQLPass.Size = new System.Drawing.Size(202, 20);
            this.txtSQLPass.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbInstances);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 54);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instance:";
            // 
            // cmbInstances
            // 
            this.cmbInstances.FormattingEnabled = true;
            this.cmbInstances.Location = new System.Drawing.Point(6, 19);
            this.cmbInstances.Name = "cmbInstances";
            this.cmbInstances.Size = new System.Drawing.Size(291, 21);
            this.cmbInstances.TabIndex = 0;
            this.cmbInstances.Click += new System.EventHandler(this.cmbInstances_Click);
            // 
            // btnSQLConnect
            // 
            this.btnSQLConnect.Location = new System.Drawing.Point(12, 139);
            this.btnSQLConnect.Name = "btnSQLConnect";
            this.btnSQLConnect.Size = new System.Drawing.Size(303, 39);
            this.btnSQLConnect.TabIndex = 6;
            this.btnSQLConnect.Text = "Connect";
            this.btnSQLConnect.UseVisualStyleBackColor = true;
            this.btnSQLConnect.Click += new System.EventHandler(this.btnSQLConnect_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 187);
            this.Controls.Add(this.btnSQLConnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSQLPass);
            this.Controls.Add(this.txtSQLUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSQLUser;
        private System.Windows.Forms.TextBox txtSQLPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbInstances;
        private System.Windows.Forms.Button btnSQLConnect;
    }
}