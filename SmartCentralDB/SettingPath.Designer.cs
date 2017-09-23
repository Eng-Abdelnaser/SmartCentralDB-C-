namespace SmartCentralDB
{
    partial class SettingPath
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SQLServerAuttentication = new System.Windows.Forms.RadioButton();
            this.WindowsAuttentication = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PassWordAutt = new System.Windows.Forms.TextBox();
            this.UserNameAutt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butclose = new System.Windows.Forms.Button();
            this.ButSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ServerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(27, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(384, 423);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اعدادات الاتصال بالسرفر";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SQLServerAuttentication);
            this.groupBox3.Controls.Add(this.WindowsAuttentication);
            this.groupBox3.Location = new System.Drawing.Point(22, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(338, 116);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mode";
            // 
            // SQLServerAuttentication
            // 
            this.SQLServerAuttentication.AutoSize = true;
            this.SQLServerAuttentication.Location = new System.Drawing.Point(37, 72);
            this.SQLServerAuttentication.Name = "SQLServerAuttentication";
            this.SQLServerAuttentication.Size = new System.Drawing.Size(197, 23);
            this.SQLServerAuttentication.TabIndex = 5;
            this.SQLServerAuttentication.Text = "SQLServerAuttentication";
            this.SQLServerAuttentication.UseVisualStyleBackColor = true;
            this.SQLServerAuttentication.CheckedChanged += new System.EventHandler(this.SQLServerAuttentication_CheckedChanged);
            // 
            // WindowsAuttentication
            // 
            this.WindowsAuttentication.AutoSize = true;
            this.WindowsAuttentication.Checked = true;
            this.WindowsAuttentication.Location = new System.Drawing.Point(37, 34);
            this.WindowsAuttentication.Name = "WindowsAuttentication";
            this.WindowsAuttentication.Size = new System.Drawing.Size(181, 23);
            this.WindowsAuttentication.TabIndex = 4;
            this.WindowsAuttentication.TabStop = true;
            this.WindowsAuttentication.Text = "WindowsAuttentication";
            this.WindowsAuttentication.UseVisualStyleBackColor = true;
            this.WindowsAuttentication.CheckedChanged += new System.EventHandler(this.WindowsAuttentication_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PassWordAutt);
            this.groupBox2.Controls.Add(this.UserNameAutt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(22, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(338, 153);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Of Logo";
            // 
            // PassWordAutt
            // 
            this.PassWordAutt.Location = new System.Drawing.Point(94, 95);
            this.PassWordAutt.Name = "PassWordAutt";
            this.PassWordAutt.ReadOnly = true;
            this.PassWordAutt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PassWordAutt.Size = new System.Drawing.Size(161, 26);
            this.PassWordAutt.TabIndex = 14;
            // 
            // UserNameAutt
            // 
            this.UserNameAutt.Location = new System.Drawing.Point(94, 50);
            this.UserNameAutt.Name = "UserNameAutt";
            this.UserNameAutt.ReadOnly = true;
            this.UserNameAutt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserNameAutt.Size = new System.Drawing.Size(161, 26);
            this.UserNameAutt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "PassWord";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "UserName";
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(79, 48);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(161, 26);
            this.ServerName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // butclose
            // 
            this.butclose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.butclose.Location = new System.Drawing.Point(49, 463);
            this.butclose.Name = "butclose";
            this.butclose.Size = new System.Drawing.Size(119, 36);
            this.butclose.TabIndex = 7;
            this.butclose.Text = "الخروج";
            this.butclose.UseVisualStyleBackColor = true;
            this.butclose.Click += new System.EventHandler(this.butclose_Click);
            // 
            // ButSave
            // 
            this.ButSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.ButSave.Location = new System.Drawing.Point(241, 463);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(119, 36);
            this.ButSave.TabIndex = 6;
            this.ButSave.Text = "حفظ الاعدادات";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // SettingPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(438, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butclose);
            this.Controls.Add(this.ButSave);
            this.Name = "SettingPath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingPath";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton SQLServerAuttentication;
        private System.Windows.Forms.RadioButton WindowsAuttentication;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PassWordAutt;
        private System.Windows.Forms.TextBox UserNameAutt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butclose;
        private System.Windows.Forms.Button ButSave;

    }
}