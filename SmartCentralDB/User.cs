using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCentralDB
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (users.Text == string.Empty || users_name.Text == string.Empty || passward.Text == string.Empty || combodegre.Text == string.Empty)
            {
                MessageBox.Show("يجب جميع الحقول", "Error");
                users.Focus();
            }
            else
            {
                var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                DB.User saveuser = new DB.User
                {
                    ID = users.Text,
                    PassWord = passward.Text,
                    Name = users_name.Text,
                    Degre = combodegre.Text
                };
                DBonWork.Users.InsertOnSubmit(saveuser);
                DBonWork.SubmitChanges();
                users.Clear();
                users_name.Clear();
                passward.Clear();
                users.Focus();
            }
        }
        private void users_Validated(object sender, EventArgs e)
        {
            var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
            var verify = from c in DBonWork.Users
                         where c.ID == users.Text.Trim()
                         select c;
            if (verify.Count() > 0)
            {
                MessageBox.Show("هذا المستخدم موجود بالفعل", "Error");
                users.Focus();
            }
        }

        private void users_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                var verify = from c in DBonWork.Users
                             where c.ID == users.Text.Trim()
                             select c;
                if (verify.Count() > 0)
                {
                    MessageBox.Show("هذا المستخدم موجود بالفعل", "Error");
                    users.Focus();
                }
                else
                    users_name.Focus();
            }
        }
        private void users_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                passward.Focus();
        }
        private void passward_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                combodegre.Focus();
        }
        private void combodegre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                add.Focus();
        }
    }
}
