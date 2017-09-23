namespace SmartCentralDB
{
    partial class CreateBakUp
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
            this.SelectFolder = new System.Windows.Forms.Button();
            this.CreatBakUp = new System.Windows.Forms.Button();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.folderBD = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(6, 37);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(117, 29);
            this.SelectFolder.TabIndex = 0;
            this.SelectFolder.Text = "اختيار مجلد";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // CreatBakUp
            // 
            this.CreatBakUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.CreatBakUp.Location = new System.Drawing.Point(23, 134);
            this.CreatBakUp.Name = "CreatBakUp";
            this.CreatBakUp.Size = new System.Drawing.Size(117, 31);
            this.CreatBakUp.TabIndex = 8;
            this.CreatBakUp.Text = "انشاء";
            this.CreatBakUp.UseVisualStyleBackColor = true;
            this.CreatBakUp.Click += new System.EventHandler(this.CreatBakUp_Click);
            // 
            // FolderPath
            // 
            this.FolderPath.BackColor = System.Drawing.Color.Wheat;
            this.FolderPath.Location = new System.Drawing.Point(129, 37);
            this.FolderPath.Multiline = true;
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.ReadOnly = true;
            this.FolderPath.Size = new System.Drawing.Size(480, 29);
            this.FolderPath.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.FolderPath);
            this.groupBox1.Controls.Add(this.SelectFolder);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 93);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مسار النسخة المحفوظة";
            // 
            // CreateBakUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(649, 183);
            this.Controls.Add(this.CreatBakUp);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateBakUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateBakUp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.Button CreatBakUp;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.FolderBrowserDialog folderBD;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}