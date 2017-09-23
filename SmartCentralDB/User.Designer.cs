namespace SmartCentralDB
{
    partial class User
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
            this.combodegre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passward = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.users_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.users = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.combodegre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.passward);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.users_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.users);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 345);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المستخدم";
            // 
            // combodegre
            // 
            this.combodegre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combodegre.FormattingEnabled = true;
            this.combodegre.Items.AddRange(new object[] {
            "مدير",
            "عادى"});
            this.combodegre.Location = new System.Drawing.Point(158, 194);
            this.combodegre.Name = "combodegre";
            this.combodegre.Size = new System.Drawing.Size(100, 27);
            this.combodegre.TabIndex = 3;
            this.combodegre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combodegre_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "درجة المستخدم";
            // 
            // passward
            // 
            this.passward.Location = new System.Drawing.Point(158, 145);
            this.passward.Name = "passward";
            this.passward.Size = new System.Drawing.Size(100, 26);
            this.passward.TabIndex = 2;
            this.passward.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passward_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "كلمة السر";
            // 
            // users_name
            // 
            this.users_name.Location = new System.Drawing.Point(6, 100);
            this.users_name.Name = "users_name";
            this.users_name.Size = new System.Drawing.Size(252, 26);
            this.users_name.TabIndex = 1;
            this.users_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.users_name_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "اسم المستخدم بالكامل";
            // 
            // users
            // 
            this.users.Location = new System.Drawing.Point(158, 46);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(100, 26);
            this.users.TabIndex = 0;
            this.users.KeyDown += new System.Windows.Forms.KeyEventHandler(this.users_KeyDown);
            this.users.Validated += new System.EventHandler(this.users_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم المستخدم";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(158, 261);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 28);
            this.add.TabIndex = 4;
            this.add.Text = "حفظ";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(440, 388);
            this.Controls.Add(this.groupBox1);
            this.Name = "User";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combodegre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passward;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox users_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
    }
}