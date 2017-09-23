using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartCentralDB
{
    public partial class Main : Form
    {
        PublicClass pr = new PublicClass();
        public string control_settingpath = "";
        public static Hashtable CabelInfo = new Hashtable();
        public static Hashtable CabinaInfo = new Hashtable();
        public static Hashtable DPInfo = new Hashtable();
        public static Hashtable SpareDPInfo = new Hashtable();
        private static Main main;
        static void main_formclosed(object sender,FormClosedEventArgs e)
        {
            main = null;
        }
        public static Main getmain
        {
            get
            {
                if (main == null)
                {
                    main = new Main();
                    main.FormClosed += new FormClosedEventHandler(main_formclosed);
                }
                return main;
            }
        }
        public Main()
        {
            InitializeComponent();
            if (main == null)
                main = this;
            this.بكسToolStripMenuItem.Visible = false;
            this.كبينةToolStripMenuItem.Visible = false;
            this.المستخدمينToolStripMenuItem.Visible = false;
            this.استعادةنسخةمحفوظةToolStripMenuItem.Visible = false;
            this.المستخدمينToolStripMenuItem.Visible = false;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Visible = false;
            this.سنترالToolStripMenuItem.Visible = false;
        }
        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn frm = new LogIn();
            frm.ShowDialog();
            if (Program.UserDgre)
            {
                this.بكسToolStripMenuItem.Visible = true;
                this.كبينةToolStripMenuItem.Visible = true;
                this.المستخدمينToolStripMenuItem.Visible = true;
                this.استعادةنسخةمحفوظةToolStripMenuItem.Visible = true;
                this.المستخدمينToolStripMenuItem.Visible = true;
                this.انشاءنسخةاحتياطيةToolStripMenuItem.Visible = true;
                this.سنترالToolStripMenuItem.Visible = true;
            }
            else
            {
                this.بكسToolStripMenuItem.Visible = true;
                this.كبينةToolStripMenuItem.Visible = true;
                this.سنترالToolStripMenuItem.Visible = true;

            }
        }
        private void الخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void انشاءنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBakUp frm = new CreateBakUp();
            frm.ShowDialog();
        }
        private void استعادةنسخةمحفوظةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restoration_BakUp frm = new Restoration_BakUp();
            frm.ShowDialog();
        }
        private void اعداداتالاتصالبالسرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingPath frm = new SettingPath();
            frm.ShowDialog();
        }
        private void تعديلسنترالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrat_Central frm = new Administrat_Central();
            frm.ShowDialog();
        }
        private void اضافهكابينةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCabina frm = new AddCabina();
            frm.ShowDialog();
        }
        private void ادارةالكبينةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrat_Cabina frm = new Administrat_Cabina();
            frm.ShowDialog();

        }
        private void اضافةبكسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDP frm = new AddDP();
            frm.ShowDialog();
        }
        private void ادارةالبكسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrat_DP frm = new Administrat_DP();
            frm.ShowDialog();

        }
        private void اضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User frm = new User();
            frm.ShowDialog();
        }
        private void ادارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserBesines frm = new UserBesines();
            frm.ShowDialog();
        }
        private void initialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PublicClass pr = new PublicClass();
                var CreatDB = new DB.SmartCentralDB(Properties.Settings.Default.ConctToMaster);
                if (!CreatDB.DatabaseExists())
                {
                    CreatDB.CreateDatabase();
                    var InDB = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                    var userdb = from us in InDB.Users
                                 where us.ID == "Admin"
                                 select us;
                    if (userdb.Count() == 0)
                    {
                        DB.User first = new DB.User { ID = "Admin", PassWord = "Admin", Name = "Admin", Degre = "مدير" };
                        InDB.Users.InsertOnSubmit(first);
                        InDB.SubmitChanges();
                    }
                foreach (string item in CreateProc.createproctural)
                    pr.InsertQury(item);
                MessageBox.Show("تم تكوين قاعدة البيانات بنجاح");
                }
                else
                    MessageBox.Show(" قاعدة البيانات مهيئة بالفعل");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n خطاء اثناء تكوين قاعدة البيانات اضبط اعدادات الاتصال بالخادم ");
            }

        }
    }
}
