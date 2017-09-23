namespace SmartCentralDB
{
    partial class UserBesines
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
            this.delet = new System.Windows.Forms.Button();
            this.combodegre = new System.Windows.Forms.ComboBox();
            this.modifay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.passward = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.users_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.users = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passWordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // delet
            // 
            this.delet.Location = new System.Drawing.Point(56, 233);
            this.delet.Name = "delet";
            this.delet.Size = new System.Drawing.Size(101, 31);
            this.delet.TabIndex = 6;
            this.delet.Text = "حذف";
            this.delet.UseVisualStyleBackColor = true;
            this.delet.Click += new System.EventHandler(this.delet_Click);
            // 
            // combodegre
            // 
            this.combodegre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combodegre.FormattingEnabled = true;
            this.combodegre.Items.AddRange(new object[] {
            "مدير",
            "عادى"});
            this.combodegre.Location = new System.Drawing.Point(117, 146);
            this.combodegre.Name = "combodegre";
            this.combodegre.Size = new System.Drawing.Size(116, 27);
            this.combodegre.TabIndex = 3;
            // 
            // modifay
            // 
            this.modifay.Location = new System.Drawing.Point(193, 233);
            this.modifay.Name = "modifay";
            this.modifay.Size = new System.Drawing.Size(104, 31);
            this.modifay.TabIndex = 5;
            this.modifay.Text = "تعديل";
            this.modifay.UseVisualStyleBackColor = true;
            this.modifay.Click += new System.EventHandler(this.modifay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "درجة المستخدم";
            // 
            // passward
            // 
            this.passward.Location = new System.Drawing.Point(117, 108);
            this.passward.Name = "passward";
            this.passward.Size = new System.Drawing.Size(116, 26);
            this.passward.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "كلمة السر";
            // 
            // users_name
            // 
            this.users_name.Location = new System.Drawing.Point(6, 68);
            this.users_name.Name = "users_name";
            this.users_name.Size = new System.Drawing.Size(227, 26);
            this.users_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "اسم المستخدم بالكامل";
            // 
            // users
            // 
            this.users.Location = new System.Drawing.Point(117, 28);
            this.users.Name = "users";
            this.users.ReadOnly = true;
            this.users.Size = new System.Drawing.Size(116, 26);
            this.users.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم المستخدم";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DB.User);
            // 
            // passWordDataGridViewTextBoxColumn
            // 
            this.passWordDataGridViewTextBoxColumn.DataPropertyName = "PassWord";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWordDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.passWordDataGridViewTextBoxColumn.FillWeight = 131.9797F;
            this.passWordDataGridViewTextBoxColumn.HeaderText = "PassWord";
            this.passWordDataGridViewTextBoxColumn.Name = "passWordDataGridViewTextBoxColumn";
            this.passWordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.iDDataGridViewTextBoxColumn.FillWeight = 89.49809F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // degreDataGridViewTextBoxColumn
            // 
            this.degreDataGridViewTextBoxColumn.DataPropertyName = "Degre";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.degreDataGridViewTextBoxColumn.FillWeight = 61.03324F;
            this.degreDataGridViewTextBoxColumn.HeaderText = "درجة المستخدم";
            this.degreDataGridViewTextBoxColumn.Name = "degreDataGridViewTextBoxColumn";
            this.degreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.nameDataGridViewTextBoxColumn.FillWeight = 117.489F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "اسم المستخدم";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.degreDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.passWordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(475, 332);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(403, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 357);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عرض البيانات";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.delet);
            this.groupBox1.Controls.Add(this.combodegre);
            this.groupBox1.Controls.Add(this.modifay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.passward);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.users_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.users);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 354);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المستخدم";
            // 
            // UserBesines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(896, 383);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserBesines";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserBesines";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delet;
        private System.Windows.Forms.ComboBox combodegre;
        private System.Windows.Forms.Button modifay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passward;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox users_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn passWordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}