namespace SmartCentralDB
{
    partial class AddCabina
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
            this.button1 = new System.Windows.Forms.Button();
            this.ComboType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tetarea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CabinaCabel = new System.Windows.Forms.TextBox();
            this.combocent = new System.Windows.Forms.ComboBox();
            this.GrBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ODU = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AreaDP = new System.Windows.Forms.TextBox();
            this.SaveBt = new System.Windows.Forms.Button();
            this.DPNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ComboCabina = new System.Windows.Forms.ComboBox();
            this.ComboCentral = new System.Windows.Forms.ComboBox();
            this.GrBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Agency FB", 12F);
            this.button1.Location = new System.Drawing.Point(242, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboType
            // 
            this.ComboType.FormattingEnabled = true;
            this.ComboType.Location = new System.Drawing.Point(399, 74);
            this.ComboType.Name = "ComboType";
            this.ComboType.Size = new System.Drawing.Size(147, 27);
            this.ComboType.TabIndex = 2;
            this.ComboType.SelectedIndexChanged += new System.EventHandler(this.ComboType_SelectedIndexChanged);
            this.ComboType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboType_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "العنوان:";
            // 
            // tetarea
            // 
            this.tetarea.Location = new System.Drawing.Point(19, 191);
            this.tetarea.MaxLength = 200;
            this.tetarea.Name = "tetarea";
            this.tetarea.Size = new System.Drawing.Size(527, 26);
            this.tetarea.TabIndex = 5;
            this.tetarea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tetarea_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = " الكابل:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "كابينة:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "سنترال:";
            // 
            // CabinaCabel
            // 
            this.CabinaCabel.Location = new System.Drawing.Point(399, 132);
            this.CabinaCabel.MaxLength = 10;
            this.CabinaCabel.Name = "CabinaCabel";
            this.CabinaCabel.Size = new System.Drawing.Size(145, 26);
            this.CabinaCabel.TabIndex = 3;
            this.CabinaCabel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CabinaCabel_KeyDown);
            this.CabinaCabel.Validated += new System.EventHandler(this.CabinaCabel_Validated);
            // 
            // combocent
            // 
            this.combocent.FormattingEnabled = true;
            this.combocent.Location = new System.Drawing.Point(399, 24);
            this.combocent.Name = "combocent";
            this.combocent.Size = new System.Drawing.Size(147, 27);
            this.combocent.TabIndex = 0;
            this.combocent.SelectedIndexChanged += new System.EventHandler(this.combocent_SelectedIndexChanged);
            // 
            // GrBox
            // 
            this.GrBox.Controls.Add(this.button1);
            this.GrBox.Controls.Add(this.label6);
            this.GrBox.Controls.Add(this.ODU);
            this.GrBox.Controls.Add(this.ComboType);
            this.GrBox.Controls.Add(this.label4);
            this.GrBox.Controls.Add(this.tetarea);
            this.GrBox.Controls.Add(this.label5);
            this.GrBox.Controls.Add(this.label3);
            this.GrBox.Controls.Add(this.label1);
            this.GrBox.Controls.Add(this.CabinaCabel);
            this.GrBox.Controls.Add(this.combocent);
            this.GrBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.GrBox.Location = new System.Drawing.Point(12, 12);
            this.GrBox.Name = "GrBox";
            this.GrBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrBox.Size = new System.Drawing.Size(662, 293);
            this.GrBox.TabIndex = 18;
            this.GrBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(328, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "ODU";
            // 
            // ODU
            // 
            this.ODU.Location = new System.Drawing.Point(260, 76);
            this.ODU.MaxLength = 10;
            this.ODU.Name = "ODU";
            this.ODU.Size = new System.Drawing.Size(62, 26);
            this.ODU.TabIndex = 13;
            this.ODU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ODU_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.AreaDP);
            this.groupBox1.Controls.Add(this.SaveBt);
            this.groupBox1.Controls.Add(this.DPNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ComboCabina);
            this.groupBox1.Controls.Add(this.ComboCentral);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 341);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // AreaDP
            // 
            this.AreaDP.Location = new System.Drawing.Point(17, 253);
            this.AreaDP.MaxLength = 200;
            this.AreaDP.Name = "AreaDP";
            this.AreaDP.Size = new System.Drawing.Size(580, 26);
            this.AreaDP.TabIndex = 9;
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
            // 
            // DPNumber
            // 
            this.DPNumber.Location = new System.Drawing.Point(470, 189);
            this.DPNumber.MaxLength = 10;
            this.DPNumber.Name = "DPNumber";
            this.DPNumber.Size = new System.Drawing.Size(127, 26);
            this.DPNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "منطقة";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(612, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "DP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(615, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "كابينة";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(615, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "سنترال";
            // 
            // ComboCabina
            // 
            this.ComboCabina.FormattingEnabled = true;
            this.ComboCabina.Location = new System.Drawing.Point(470, 133);
            this.ComboCabina.Name = "ComboCabina";
            this.ComboCabina.Size = new System.Drawing.Size(127, 27);
            this.ComboCabina.TabIndex = 2;
            // 
            // ComboCentral
            // 
            this.ComboCentral.FormattingEnabled = true;
            this.ComboCentral.Location = new System.Drawing.Point(470, 65);
            this.ComboCentral.Name = "ComboCentral";
            this.ComboCentral.Size = new System.Drawing.Size(127, 27);
            this.ComboCentral.TabIndex = 0;
            // 
            // AddCabina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(694, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCabina";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCabina";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCabina_FormClosed);
            this.GrBox.ResumeLayout(false);
            this.GrBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox ComboType;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tetarea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox CabinaCabel;
        public System.Windows.Forms.ComboBox combocent;
        private System.Windows.Forms.GroupBox GrBox;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox ODU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AreaDP;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.TextBox DPNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ComboCabina;
        private System.Windows.Forms.ComboBox ComboCentral;
    }
}

