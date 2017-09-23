namespace SmartCentralDB
{
    partial class LogIn
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
            this.ID = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(119, 27);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(191, 26);
            this.ID.TabIndex = 0;
            this.ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_KeyDown);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(69, 132);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(121, 27);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "خروج";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم المستخدم";
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(119, 63);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(191, 26);
            this.Pass.TabIndex = 1;
            this.Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pass_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "كلمة السر";
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(234, 132);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(121, 27);
            this.Insert.TabIndex = 2;
            this.Insert.Text = "الدخول";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.Cancel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Pass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Insert);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 202);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(508, 218);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}