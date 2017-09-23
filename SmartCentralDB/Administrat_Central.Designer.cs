namespace SmartCentralDB
{
    partial class Administrat_Central
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
            this.ModifyCabel = new System.Windows.Forms.Button();
            this.cabelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.punctuationENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punctuationBGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cableNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DeletCabel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveCabel = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Modify = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CenteralToSave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.centralNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModifyCentral = new System.Windows.Forms.TextBox();
            this.CellactCentral = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cabelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModifyCabel
            // 
            this.ModifyCabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.ModifyCabel.Location = new System.Drawing.Point(477, 517);
            this.ModifyCabel.Name = "ModifyCabel";
            this.ModifyCabel.Size = new System.Drawing.Size(119, 35);
            this.ModifyCabel.TabIndex = 20;
            this.ModifyCabel.Text = "تعديل";
            this.ModifyCabel.UseVisualStyleBackColor = true;
            this.ModifyCabel.Click += new System.EventHandler(this.ModifyCabel_Click);
            // 
            // cabelBindingSource
            // 
            this.cabelBindingSource.DataSource = typeof(DB.Cabel);
            // 
            // punctuationENDataGridViewTextBoxColumn
            // 
            this.punctuationENDataGridViewTextBoxColumn.DataPropertyName = "PunctuationEN";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.punctuationENDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.punctuationENDataGridViewTextBoxColumn.HeaderText = "نهاية الترقيم";
            this.punctuationENDataGridViewTextBoxColumn.Name = "punctuationENDataGridViewTextBoxColumn";
            this.punctuationENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // punctuationBGDataGridViewTextBoxColumn
            // 
            this.punctuationBGDataGridViewTextBoxColumn.DataPropertyName = "PunctuationBG";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.punctuationBGDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.punctuationBGDataGridViewTextBoxColumn.HeaderText = "بداية الترقيم";
            this.punctuationBGDataGridViewTextBoxColumn.Name = "punctuationBGDataGridViewTextBoxColumn";
            this.punctuationBGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cableNumberDataGridViewTextBoxColumn
            // 
            this.cableNumberDataGridViewTextBoxColumn.DataPropertyName = "CableNumber";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cableNumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.cableNumberDataGridViewTextBoxColumn.HeaderText = "كابل";
            this.cableNumberDataGridViewTextBoxColumn.Name = "cableNumberDataGridViewTextBoxColumn";
            this.cableNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Bisque;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cableNumberDataGridViewTextBoxColumn,
            this.punctuationBGDataGridViewTextBoxColumn,
            this.punctuationENDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.cabelBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(348, 256);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView2);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(407, 230);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(354, 281);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "قائمة الكابلات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "/";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 19);
            this.textBox3.MaxLength = 11;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 26);
            this.textBox3.TabIndex = 2;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 19);
            this.textBox2.MaxLength = 11;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // DeletCabel
            // 
            this.DeletCabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.DeletCabel.Location = new System.Drawing.Point(628, 517);
            this.DeletCabel.Name = "DeletCabel";
            this.DeletCabel.Size = new System.Drawing.Size(118, 35);
            this.DeletCabel.TabIndex = 19;
            this.DeletCabel.Text = "حذف";
            this.DeletCabel.UseVisualStyleBackColor = true;
            this.DeletCabel.Click += new System.EventHandler(this.DeletCabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "سنترال";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.SaveCabel);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(407, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(354, 194);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "اضافة كابل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "كابل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "النوع";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(181, 70);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // SaveCabel
            // 
            this.SaveCabel.Location = new System.Drawing.Point(98, 160);
            this.SaveCabel.Name = "SaveCabel";
            this.SaveCabel.Size = new System.Drawing.Size(122, 28);
            this.SaveCabel.TabIndex = 2;
            this.SaveCabel.Text = "اضافة";
            this.SaveCabel.UseVisualStyleBackColor = true;
            this.SaveCabel.Click += new System.EventHandler(this.SaveCabel_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Location = new System.Drawing.Point(6, 101);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(322, 53);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "الترقيم";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(15, 69);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(118, 27);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox2_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 27);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(6, 56);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(81, 26);
            this.Modify.TabIndex = 3;
            this.Modify.Text = "تعديل";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(6, 23);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(81, 28);
            this.Save.TabIndex = 1;
            this.Save.Text = "حفظ";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.CenteralToSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 69);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // CenteralToSave
            // 
            this.CenteralToSave.Location = new System.Drawing.Point(103, 25);
            this.CenteralToSave.MaxLength = 30;
            this.CenteralToSave.Name = "CenteralToSave";
            this.CenteralToSave.Size = new System.Drawing.Size(180, 26);
            this.CenteralToSave.TabIndex = 0;
            this.CenteralToSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CenteralToSave_KeyDown);
            this.CenteralToSave.Validated += new System.EventHandler(this.CenteralToSave_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "اضافة سنترال:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(109, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 281);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "قائمة السنترالات";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Bisque;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.centralNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.centralBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(217, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // centralNameDataGridViewTextBoxColumn
            // 
            this.centralNameDataGridViewTextBoxColumn.DataPropertyName = "CentralName";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.centralNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.centralNameDataGridViewTextBoxColumn.HeaderText = "سنترال";
            this.centralNameDataGridViewTextBoxColumn.Name = "centralNameDataGridViewTextBoxColumn";
            this.centralNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // centralBindingSource
            // 
            this.centralBindingSource.DataSource = typeof(DB.Central);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.ModifyCentral);
            this.groupBox3.Controls.Add(this.CellactCentral);
            this.groupBox3.Controls.Add(this.Delete);
            this.groupBox3.Controls.Add(this.Modify);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(9, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 119);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "الاسم الجديد:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "السنترال الحالى:";
            // 
            // ModifyCentral
            // 
            this.ModifyCentral.Location = new System.Drawing.Point(103, 56);
            this.ModifyCentral.MaxLength = 30;
            this.ModifyCentral.Name = "ModifyCentral";
            this.ModifyCentral.Size = new System.Drawing.Size(174, 26);
            this.ModifyCentral.TabIndex = 2;
            this.ModifyCentral.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModifyCentral_KeyDown);
            this.ModifyCentral.Validated += new System.EventHandler(this.ModifyCentral_Validated);
            // 
            // CellactCentral
            // 
            this.CellactCentral.BackColor = System.Drawing.Color.Tan;
            this.CellactCentral.Location = new System.Drawing.Point(103, 19);
            this.CellactCentral.Name = "CellactCentral";
            this.CellactCentral.ReadOnly = true;
            this.CellactCentral.Size = new System.Drawing.Size(174, 26);
            this.CellactCentral.TabIndex = 5;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(6, 19);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(81, 26);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "حذف";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Administrat_Central
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(771, 561);
            this.Controls.Add(this.ModifyCabel);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.DeletCabel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Administrat_Central";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrat_Central";
            ((System.ComponentModel.ISupportInitialize)(this.cabelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ModifyCabel;
        private System.Windows.Forms.BindingSource cabelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn punctuationENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn punctuationBGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cableNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button DeletCabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SaveCabel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CenteralToSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn centralNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource centralBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ModifyCentral;
        private System.Windows.Forms.TextBox CellactCentral;
        private System.Windows.Forms.Button Delete;
    }
}