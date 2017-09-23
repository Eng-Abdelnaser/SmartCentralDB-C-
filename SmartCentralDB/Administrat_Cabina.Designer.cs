namespace SmartCentralDB
{
    partial class Administrat_Cabina
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.centralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BGPunctation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENPunctation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CABINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ODU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CableNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpData = new System.Windows.Forms.Button();
            this.area = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GroBox = new System.Windows.Forms.GroupBox();
            this.delet = new System.Windows.Forms.Button();
            this.modifay = new System.Windows.Forms.Button();
            this.cabelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboCabina = new System.Windows.Forms.ComboBox();
            this.Street = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SerchAsArea = new System.Windows.Forms.Button();
            this.ComboCentral = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SerchAsCabina = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cabinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CentralName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cABINADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PunctuationBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PunctuationEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.centralBindingSource)).BeginInit();
            this.GroBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cabelBindingSource)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // centralBindingSource
            // 
            this.centralBindingSource.DataSource = typeof(DB.Central);
            // 
            // BGPunctation
            // 
            this.BGPunctation.Name = "BGPunctation";
            // 
            // ENPunctation
            // 
            this.ENPunctation.Name = "ENPunctation";
            // 
            // CABINA
            // 
            this.CABINA.Name = "CABINA";
            // 
            // ODU
            // 
            this.ODU.Name = "ODU";
            // 
            // CableNumber
            // 
            this.CableNumber.Name = "CableNumber";
            // 
            // UpData
            // 
            this.UpData.Font = new System.Drawing.Font("Agency FB", 12F);
            this.UpData.Location = new System.Drawing.Point(114, 75);
            this.UpData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UpData.Name = "UpData";
            this.UpData.Size = new System.Drawing.Size(102, 28);
            this.UpData.TabIndex = 28;
            this.UpData.Text = "تحديث";
            this.UpData.UseVisualStyleBackColor = true;
            this.UpData.Click += new System.EventHandler(this.UpData_Click);
            // 
            // area
            // 
            this.area.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.area.Location = new System.Drawing.Point(114, 28);
            this.area.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.area.MaxLength = 200;
            this.area.Name = "area";
            this.area.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.area.Size = new System.Drawing.Size(660, 26);
            this.area.TabIndex = 3;
            this.area.KeyDown += new System.Windows.Forms.KeyEventHandler(this.area_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label4.Location = new System.Drawing.Point(778, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "منطقة";
            // 
            // GroBox
            // 
            this.GroBox.BackColor = System.Drawing.Color.LightBlue;
            this.GroBox.Controls.Add(this.UpData);
            this.GroBox.Controls.Add(this.delet);
            this.GroBox.Controls.Add(this.modifay);
            this.GroBox.Controls.Add(this.area);
            this.GroBox.Controls.Add(this.label4);
            this.GroBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.GroBox.Location = new System.Drawing.Point(15, 450);
            this.GroBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroBox.Name = "GroBox";
            this.GroBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroBox.Size = new System.Drawing.Size(826, 110);
            this.GroBox.TabIndex = 12;
            this.GroBox.TabStop = false;
            this.GroBox.Text = "تحديث البيانات";
            // 
            // delet
            // 
            this.delet.Font = new System.Drawing.Font("Agency FB", 12F);
            this.delet.Location = new System.Drawing.Point(18, 75);
            this.delet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.delet.Name = "delet";
            this.delet.Size = new System.Drawing.Size(92, 28);
            this.delet.TabIndex = 5;
            this.delet.Text = "حذف";
            this.delet.UseVisualStyleBackColor = true;
            this.delet.Click += new System.EventHandler(this.delet_Click);
            // 
            // modifay
            // 
            this.modifay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.modifay.Location = new System.Drawing.Point(18, 27);
            this.modifay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.modifay.Name = "modifay";
            this.modifay.Size = new System.Drawing.Size(90, 27);
            this.modifay.TabIndex = 4;
            this.modifay.Text = "تعديل";
            this.modifay.UseVisualStyleBackColor = true;
            this.modifay.Click += new System.EventHandler(this.modifay_Click);
            // 
            // cabelBindingSource
            // 
            this.cabelBindingSource.DataSource = typeof(DB.Cabel);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.ComboCabina);
            this.groupBox6.Controls.Add(this.Street);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.SerchAsArea);
            this.groupBox6.Controls.Add(this.ComboCentral);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.SerchAsCabina);
            this.groupBox6.Location = new System.Drawing.Point(15, 13);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(826, 95);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label7.Location = new System.Drawing.Point(294, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "كابينة";
            // 
            // ComboCabina
            // 
            this.ComboCabina.BackColor = System.Drawing.SystemColors.Window;
            this.ComboCabina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCabina.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.ComboCabina.FormattingEnabled = true;
            this.ComboCabina.Location = new System.Drawing.Point(152, 51);
            this.ComboCabina.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ComboCabina.Name = "ComboCabina";
            this.ComboCabina.Size = new System.Drawing.Size(126, 27);
            this.ComboCabina.TabIndex = 33;
            this.ComboCabina.SelectedIndexChanged += new System.EventHandler(this.ComboCabina_SelectedIndexChanged);
            // 
            // Street
            // 
            this.Street.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Street.Location = new System.Drawing.Point(488, 52);
            this.Street.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Street.MaxLength = 100;
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(248, 26);
            this.Street.TabIndex = 5;
            this.Street.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Street_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label9.Location = new System.Drawing.Point(756, 55);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = " منطقة";
            // 
            // SerchAsArea
            // 
            this.SerchAsArea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.SerchAsArea.Location = new System.Drawing.Point(385, 54);
            this.SerchAsArea.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SerchAsArea.Name = "SerchAsArea";
            this.SerchAsArea.Size = new System.Drawing.Size(90, 27);
            this.SerchAsArea.TabIndex = 6;
            this.SerchAsArea.Text = "بحث ";
            this.SerchAsArea.UseVisualStyleBackColor = true;
            this.SerchAsArea.Click += new System.EventHandler(this.SerchAsArea_Click);
            // 
            // ComboCentral
            // 
            this.ComboCentral.BackColor = System.Drawing.SystemColors.Window;
            this.ComboCentral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCentral.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.ComboCentral.FormattingEnabled = true;
            this.ComboCentral.Location = new System.Drawing.Point(589, 19);
            this.ComboCentral.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ComboCentral.Name = "ComboCentral";
            this.ComboCentral.Size = new System.Drawing.Size(147, 27);
            this.ComboCentral.TabIndex = 30;
            this.ComboCentral.SelectedIndexChanged += new System.EventHandler(this.ComboCentral_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label1.Location = new System.Drawing.Point(753, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "سنترال";
            // 
            // SerchAsCabina
            // 
            this.SerchAsCabina.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.SerchAsCabina.Location = new System.Drawing.Point(46, 51);
            this.SerchAsCabina.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SerchAsCabina.Name = "SerchAsCabina";
            this.SerchAsCabina.Size = new System.Drawing.Size(90, 28);
            this.SerchAsCabina.TabIndex = 4;
            this.SerchAsCabina.Text = "بحث";
            this.SerchAsCabina.UseVisualStyleBackColor = true;
            this.SerchAsCabina.Click += new System.EventHandler(this.SerchAsCabina_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(15, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(826, 325);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 26;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CentralName,
            this.dataGridViewTextBoxColumn2,
            this.oDUDataGridViewTextBoxColumn,
            this.cABINADataGridViewTextBoxColumn,
            this.PunctuationBG,
            this.PunctuationEN,
            this.areaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cabinaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(822, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // cabinaBindingSource
            // 
            this.cabinaBindingSource.DataSource = typeof(DB.Cabina);
            // 
            // CentralName
            // 
            this.CentralName.DataPropertyName = "CentralName";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.CentralName.DefaultCellStyle = dataGridViewCellStyle2;
            this.CentralName.FillWeight = 302.3911F;
            this.CentralName.HeaderText = "سنترال";
            this.CentralName.MinimumWidth = 70;
            this.CentralName.Name = "CentralName";
            this.CentralName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CableNumber";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.FillWeight = 4.581587F;
            this.dataGridViewTextBoxColumn2.HeaderText = "كابل";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // oDUDataGridViewTextBoxColumn
            // 
            this.oDUDataGridViewTextBoxColumn.DataPropertyName = "ODU";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.oDUDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.oDUDataGridViewTextBoxColumn.FillWeight = 9.117902F;
            this.oDUDataGridViewTextBoxColumn.HeaderText = "ODU";
            this.oDUDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.oDUDataGridViewTextBoxColumn.Name = "oDUDataGridViewTextBoxColumn";
            this.oDUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cABINADataGridViewTextBoxColumn
            // 
            this.cABINADataGridViewTextBoxColumn.DataPropertyName = "CABINA";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cABINADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.cABINADataGridViewTextBoxColumn.FillWeight = 18.31242F;
            this.cABINADataGridViewTextBoxColumn.HeaderText = "كابينة";
            this.cABINADataGridViewTextBoxColumn.MinimumWidth = 70;
            this.cABINADataGridViewTextBoxColumn.Name = "cABINADataGridViewTextBoxColumn";
            this.cABINADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PunctuationBG
            // 
            this.PunctuationBG.DataPropertyName = "PunctuationBG";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.PunctuationBG.DefaultCellStyle = dataGridViewCellStyle6;
            this.PunctuationBG.FillWeight = 36.83426F;
            this.PunctuationBG.HeaderText = "بداية الترقيم";
            this.PunctuationBG.MinimumWidth = 100;
            this.PunctuationBG.Name = "PunctuationBG";
            this.PunctuationBG.ReadOnly = true;
            // 
            // PunctuationEN
            // 
            this.PunctuationEN.DataPropertyName = "PunctuationEN";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.PunctuationEN.DefaultCellStyle = dataGridViewCellStyle7;
            this.PunctuationEN.FillWeight = 74.39242F;
            this.PunctuationEN.HeaderText = "نهاية الترقيم";
            this.PunctuationEN.MinimumWidth = 100;
            this.PunctuationEN.Name = "PunctuationEN";
            this.PunctuationEN.ReadOnly = true;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.areaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.areaDataGridViewTextBoxColumn.FillWeight = 150.0807F;
            this.areaDataGridViewTextBoxColumn.HeaderText = "المنطقة";
            this.areaDataGridViewTextBoxColumn.MinimumWidth = 330;
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Administrat_Cabina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(856, 572);
            this.Controls.Add(this.GroBox);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Name = "Administrat_Cabina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrat_Cabina";
            ((System.ComponentModel.ISupportInitialize)(this.centralBindingSource)).EndInit();
            this.GroBox.ResumeLayout(false);
            this.GroBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cabelBindingSource)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource centralBindingSource;
        //ربط الداتا جرايد مع مصدر البيانات سنترال
        private System.Windows.Forms.DataGridViewTextBoxColumn BGPunctation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENPunctation;
        private System.Windows.Forms.DataGridViewTextBoxColumn CABINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ODU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CableNumber;
        private System.Windows.Forms.Button UpData;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GroBox;
        private System.Windows.Forms.Button delet;
        private System.Windows.Forms.Button modifay;
        private System.Windows.Forms.BindingSource cabelBindingSource;
        //ربط الداتا جرايد مع مصدر البيانات كابل
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboCabina;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SerchAsArea;
        private System.Windows.Forms.ComboBox ComboCentral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SerchAsCabina;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cabinaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentralName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cABINADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PunctuationBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PunctuationEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        //ربط الداتا جرايد مع مصدر البيانات كابينة
    }
}