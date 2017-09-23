namespace SmartCentralDB
{
    partial class Restoration_BakUp
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
            this.textfilename = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.textfilename);
            this.groupBox1.Controls.Add(this.browse);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(19, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 85);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مسار النسخة المحفوظة";
            // 
            // textfilename
            // 
            this.textfilename.BackColor = System.Drawing.Color.Wheat;
            this.textfilename.Location = new System.Drawing.Point(135, 34);
            this.textfilename.Name = "textfilename";
            this.textfilename.ReadOnly = true;
            this.textfilename.Size = new System.Drawing.Size(589, 26);
            this.textfilename.TabIndex = 4;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(6, 32);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(123, 28);
            this.browse.TabIndex = 0;
            this.browse.Text = "  حدد ملف BakUp ";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.create.Location = new System.Drawing.Point(25, 105);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(123, 39);
            this.create.TabIndex = 8;
            this.create.Text = "استعادة النسخة";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Restoration_BakUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(769, 158);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.create);
            this.Name = "Restoration_BakUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restoration_BakUp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textfilename;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}