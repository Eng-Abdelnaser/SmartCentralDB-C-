namespace SmartCentralDB
{
    partial class AddDP
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
            this.AreaDP = new System.Windows.Forms.TextBox();
            this.DPNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboCabina = new System.Windows.Forms.ComboBox();
            this.ComboCentral = new System.Windows.Forms.ComboBox();
            this.SaveBt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.AreaDP);
            this.groupBox1.Controls.Add(this.SaveBt);
            this.groupBox1.Controls.Add(this.DPNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComboCabina);
            this.groupBox1.Controls.Add(this.ComboCentral);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 341);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // AreaDP
            // 
            this.AreaDP.Location = new System.Drawing.Point(17, 253);
            this.AreaDP.MaxLength = 200;
            this.AreaDP.Name = "AreaDP";
            this.AreaDP.Size = new System.Drawing.Size(580, 26);
            this.AreaDP.TabIndex = 9;
            this.AreaDP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AreaDP_KeyDown);
            // 
            // DPNumber
            // 
            this.DPNumber.Location = new System.Drawing.Point(470, 189);
            this.DPNumber.MaxLength = 10;
            this.DPNumber.Name = "DPNumber";
            this.DPNumber.Size = new System.Drawing.Size(127, 26);
            this.DPNumber.TabIndex = 3;
            this.DPNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DPNumber_KeyDown);
            this.DPNumber.Validated += new System.EventHandler(this.DPNumber_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "منطقة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(612, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "DP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "كابينة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "سنترال";
            // 
            // ComboCabina
            // 
            this.ComboCabina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCabina.FormattingEnabled = true;
            this.ComboCabina.Location = new System.Drawing.Point(470, 133);
            this.ComboCabina.Name = "ComboCabina";
            this.ComboCabina.Size = new System.Drawing.Size(127, 27);
            this.ComboCabina.TabIndex = 2;
            this.ComboCabina.SelectedIndexChanged += new System.EventHandler(this.ComboCabina_SelectedIndexChanged);
            // 
            // ComboCentral
            // 
            this.ComboCentral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCentral.FormattingEnabled = true;
            this.ComboCentral.Location = new System.Drawing.Point(470, 65);
            this.ComboCentral.Name = "ComboCentral";
            this.ComboCentral.Size = new System.Drawing.Size(127, 27);
            this.ComboCentral.TabIndex = 0;
            this.ComboCentral.SelectedIndexChanged += new System.EventHandler(this.ComboCentral_SelectedIndexChanged);
            // 
            // SaveBt
            // 
            this.SaveBt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.SaveBt.Location = new System.Drawing.Point(265, 296);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(103, 30);
            this.SaveBt.TabIndex = 12;
            this.SaveBt.Text = "حفظ";
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // AddDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(704, 417);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDP";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AreaDP;
        private System.Windows.Forms.TextBox DPNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboCabina;
        private System.Windows.Forms.ComboBox ComboCentral;
        private System.Windows.Forms.Button SaveBt;
    }
}