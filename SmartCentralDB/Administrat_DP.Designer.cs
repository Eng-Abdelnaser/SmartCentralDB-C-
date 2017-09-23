namespace SmartCentralDB
{
    partial class Administrat_DP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cabelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComboDP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Street = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delet = new System.Windows.Forms.Button();
            this.modifay = new System.Windows.Forms.Button();
            this.area = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboCabina = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SerchAsStreet = new System.Windows.Forms.Button();
            this.ComboCentral = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SerchAsDP = new System.Windows.Forms.Button();
            this.iDCableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDcentralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cableNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDcentralDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centralNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DPNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CentralName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CableNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ODU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CABINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punctuationBGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punctuationENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cabinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dPBindingSource
            // 
            this.dPBindingSource.DataSource = typeof(DB.DP);
            // 
            // cabelBindingSource
            // 
            this.cabelBindingSource.DataSource = typeof(DB.Cabel);
            // 
            // ComboDP
            // 
            this.ComboDP.BackColor = System.Drawing.SystemColors.Window;
            this.ComboDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboDP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.ComboDP.FormattingEnabled = true;
            this.ComboDP.Location = new System.Drawing.Point(114, 70);
            this.ComboDP.Name = "ComboDP";
            this.ComboDP.Size = new System.Drawing.Size(71, 27);
            this.ComboDP.TabIndex = 35;
            this.ComboDP.SelectedIndexChanged += new System.EventHandler(this.ComboDP_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(191, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "DP";
            // 
            // Street
            // 
            this.Street.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Street.Location = new System.Drawing.Point(536, 70);
            this.Street.MaxLength = 100;
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(220, 26);
            this.Street.TabIndex = 5;
            this.Street.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Street_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.delet);
            this.groupBox1.Controls.Add(this.modifay);
            this.groupBox1.Controls.Add(this.area);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(826, 124);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تحديث البيانات";
            // 
            // delet
            // 
            this.delet.Location = new System.Drawing.Point(30, 82);
            this.delet.Name = "delet";
            this.delet.Size = new System.Drawing.Size(108, 36);
            this.delet.TabIndex = 5;
            this.delet.Text = "حذف";
            this.delet.UseVisualStyleBackColor = true;
            this.delet.Click += new System.EventHandler(this.delet_Click);
            // 
            // modifay
            // 
            this.modifay.Location = new System.Drawing.Point(144, 82);
            this.modifay.Name = "modifay";
            this.modifay.Size = new System.Drawing.Size(112, 36);
            this.modifay.TabIndex = 4;
            this.modifay.Text = "تعديل";
            this.modifay.UseVisualStyleBackColor = true;
            this.modifay.Click += new System.EventHandler(this.modifay_Click);
            // 
            // area
            // 
            this.area.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.area.Location = new System.Drawing.Point(30, 30);
            this.area.MaxLength = 200;
            this.area.Name = "area";
            this.area.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.area.Size = new System.Drawing.Size(726, 26);
            this.area.TabIndex = 3;
            this.area.KeyDown += new System.Windows.Forms.KeyEventHandler(this.area_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(772, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "منطقة";
            // 
            // ComboCabina
            // 
            this.ComboCabina.BackColor = System.Drawing.SystemColors.Window;
            this.ComboCabina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCabina.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.ComboCabina.FormattingEnabled = true;
            this.ComboCabina.Location = new System.Drawing.Point(227, 69);
            this.ComboCabina.Name = "ComboCabina";
            this.ComboCabina.Size = new System.Drawing.Size(91, 27);
            this.ComboCabina.TabIndex = 33;
            this.ComboCabina.SelectedIndexChanged += new System.EventHandler(this.ComboCabina_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox6.Controls.Add(this.ComboDP);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.Street);
            this.groupBox6.Controls.Add(this.ComboCabina);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.SerchAsStreet);
            this.groupBox6.Controls.Add(this.ComboCentral);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.SerchAsDP);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(826, 115);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label9.Location = new System.Drawing.Point(778, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = " منطقة";
            // 
            // SerchAsStreet
            // 
            this.SerchAsStreet.Font = new System.Drawing.Font("Agency FB", 12F);
            this.SerchAsStreet.Location = new System.Drawing.Point(402, 69);
            this.SerchAsStreet.Name = "SerchAsStreet";
            this.SerchAsStreet.Size = new System.Drawing.Size(112, 26);
            this.SerchAsStreet.TabIndex = 6;
            this.SerchAsStreet.Text = "بحث ";
            this.SerchAsStreet.UseVisualStyleBackColor = true;
            this.SerchAsStreet.Click += new System.EventHandler(this.SerchAsStreet_Click);
            // 
            // ComboCentral
            // 
            this.ComboCentral.BackColor = System.Drawing.SystemColors.Window;
            this.ComboCentral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCentral.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.ComboCentral.FormattingEnabled = true;
            this.ComboCentral.Location = new System.Drawing.Point(634, 19);
            this.ComboCentral.Name = "ComboCentral";
            this.ComboCentral.Size = new System.Drawing.Size(122, 27);
            this.ComboCentral.TabIndex = 30;
            this.ComboCentral.SelectedIndexChanged += new System.EventHandler(this.ComboCentral_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label1.Location = new System.Drawing.Point(764, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "سنترال";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 12F);
            this.label7.Location = new System.Drawing.Point(324, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "كابينة";
            // 
            // SerchAsDP
            // 
            this.SerchAsDP.Font = new System.Drawing.Font("Agency FB", 12F);
            this.SerchAsDP.Location = new System.Drawing.Point(6, 69);
            this.SerchAsDP.Name = "SerchAsDP";
            this.SerchAsDP.Size = new System.Drawing.Size(102, 29);
            this.SerchAsDP.TabIndex = 4;
            this.SerchAsDP.Text = "بحث";
            this.SerchAsDP.UseVisualStyleBackColor = true;
            this.SerchAsDP.Click += new System.EventHandler(this.SerchAsDP_Click);
            // 
            // iDCableDataGridViewTextBoxColumn
            // 
            this.iDCableDataGridViewTextBoxColumn.DataPropertyName = "IDCable";
            this.iDCableDataGridViewTextBoxColumn.HeaderText = "IDCable";
            this.iDCableDataGridViewTextBoxColumn.Name = "iDCableDataGridViewTextBoxColumn";
            this.iDCableDataGridViewTextBoxColumn.Width = 88;
            // 
            // oDUDataGridViewTextBoxColumn
            // 
            this.oDUDataGridViewTextBoxColumn.DataPropertyName = "ODU";
            this.oDUDataGridViewTextBoxColumn.HeaderText = "ODU";
            this.oDUDataGridViewTextBoxColumn.Name = "oDUDataGridViewTextBoxColumn";
            this.oDUDataGridViewTextBoxColumn.Width = 89;
            // 
            // iDcentralDataGridViewTextBoxColumn
            // 
            this.iDcentralDataGridViewTextBoxColumn.DataPropertyName = "IDcentral";
            this.iDcentralDataGridViewTextBoxColumn.HeaderText = "IDcentral";
            this.iDcentralDataGridViewTextBoxColumn.Name = "iDcentralDataGridViewTextBoxColumn";
            this.iDcentralDataGridViewTextBoxColumn.Width = 89;
            // 
            // cableNumberDataGridViewTextBoxColumn
            // 
            this.cableNumberDataGridViewTextBoxColumn.DataPropertyName = "CableNumber";
            this.cableNumberDataGridViewTextBoxColumn.HeaderText = "CableNumber";
            this.cableNumberDataGridViewTextBoxColumn.Name = "cableNumberDataGridViewTextBoxColumn";
            this.cableNumberDataGridViewTextBoxColumn.Width = 88;
            // 
            // centralDataGridViewTextBoxColumn
            // 
            this.centralDataGridViewTextBoxColumn.DataPropertyName = "Central";
            this.centralDataGridViewTextBoxColumn.HeaderText = "Central";
            this.centralDataGridViewTextBoxColumn.Name = "centralDataGridViewTextBoxColumn";
            this.centralDataGridViewTextBoxColumn.Width = 89;
            // 
            // iDcentralDataGridViewTextBoxColumn1
            // 
            this.iDcentralDataGridViewTextBoxColumn1.DataPropertyName = "IDcentral";
            this.iDcentralDataGridViewTextBoxColumn1.HeaderText = "IDcentral";
            this.iDcentralDataGridViewTextBoxColumn1.Name = "iDcentralDataGridViewTextBoxColumn1";
            this.iDcentralDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDcentralDataGridViewTextBoxColumn1.Width = 399;
            // 
            // centralNameDataGridViewTextBoxColumn
            // 
            this.centralNameDataGridViewTextBoxColumn.DataPropertyName = "CentralName";
            this.centralNameDataGridViewTextBoxColumn.HeaderText = "CentralName";
            this.centralNameDataGridViewTextBoxColumn.Name = "centralNameDataGridViewTextBoxColumn";
            this.centralNameDataGridViewTextBoxColumn.Width = 399;
            // 
            // cabinaBindingSource
            // 
            this.cabinaBindingSource.DataSource = typeof(DB.Cabina);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Area";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.FillWeight = 186.7754F;
            this.dataGridViewTextBoxColumn2.HeaderText = "منطقة";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // centralBindingSource
            // 
            this.centralBindingSource.DataSource = typeof(DB.Central);
            // 
            // DPNumber
            // 
            this.DPNumber.DataPropertyName = "DPNumber";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.DPNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.DPNumber.FillWeight = 70.0239F;
            this.DPNumber.HeaderText = "       DP";
            this.DPNumber.Name = "DPNumber";
            this.DPNumber.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(826, 279);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CentralName,
            this.CableNumber,
            this.ODU,
            this.CABINA,
            this.punctuationBGDataGridViewTextBoxColumn,
            this.punctuationENDataGridViewTextBoxColumn,
            this.DPNumber,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.cabelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(820, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // CentralName
            // 
            this.CentralName.DataPropertyName = "CentralName";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.CentralName.DefaultCellStyle = dataGridViewCellStyle4;
            this.CentralName.FillWeight = 125.4858F;
            this.CentralName.HeaderText = "سنترال";
            this.CentralName.Name = "CentralName";
            this.CentralName.ReadOnly = true;
            // 
            // CableNumber
            // 
            this.CableNumber.DataPropertyName = "CableNumber";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.CableNumber.DefaultCellStyle = dataGridViewCellStyle5;
            this.CableNumber.FillWeight = 39.31419F;
            this.CableNumber.HeaderText = "كابل";
            this.CableNumber.Name = "CableNumber";
            this.CableNumber.ReadOnly = true;
            // 
            // ODU
            // 
            this.ODU.DataPropertyName = "ODU";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.ODU.DefaultCellStyle = dataGridViewCellStyle6;
            this.ODU.FillWeight = 43.14484F;
            this.ODU.HeaderText = "ODU";
            this.ODU.Name = "ODU";
            this.ODU.ReadOnly = true;
            // 
            // CABINA
            // 
            this.CABINA.DataPropertyName = "CABINA";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.CABINA.DefaultCellStyle = dataGridViewCellStyle7;
            this.CABINA.FillWeight = 47.38606F;
            this.CABINA.HeaderText = "كابينة";
            this.CABINA.Name = "CABINA";
            this.CABINA.ReadOnly = true;
            // 
            // punctuationBGDataGridViewTextBoxColumn
            // 
            this.punctuationBGDataGridViewTextBoxColumn.DataPropertyName = "PunctuationBG";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.punctuationBGDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.punctuationBGDataGridViewTextBoxColumn.FillWeight = 82.25342F;
            this.punctuationBGDataGridViewTextBoxColumn.HeaderText = "بداية الترقيم";
            this.punctuationBGDataGridViewTextBoxColumn.Name = "punctuationBGDataGridViewTextBoxColumn";
            this.punctuationBGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // punctuationENDataGridViewTextBoxColumn
            // 
            this.punctuationENDataGridViewTextBoxColumn.DataPropertyName = "PunctuationEN";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.punctuationENDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.punctuationENDataGridViewTextBoxColumn.FillWeight = 95.35174F;
            this.punctuationENDataGridViewTextBoxColumn.HeaderText = "نهاية الترقيم";
            this.punctuationENDataGridViewTextBoxColumn.Name = "punctuationENDataGridViewTextBoxColumn";
            this.punctuationENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Administrat_DP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(851, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Name = "Administrat_DP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrat_DP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administrat_DP_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cabinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dPBindingSource;
        private System.Windows.Forms.BindingSource cabelBindingSource;
        private System.Windows.Forms.ComboBox ComboDP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delet;
        private System.Windows.Forms.Button modifay;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboCabina;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SerchAsStreet;
        private System.Windows.Forms.ComboBox ComboCentral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SerchAsDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcentralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cableNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcentralDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn centralNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cabinaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource centralBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentralName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CableNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ODU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CABINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn punctuationBGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn punctuationENDataGridViewTextBoxColumn;
    }
}