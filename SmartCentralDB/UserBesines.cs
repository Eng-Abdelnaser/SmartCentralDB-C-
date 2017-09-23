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
    public partial class UserBesines : Form
    {
        PublicClass pr = new PublicClass();
        List<DB.User> dt = new List<DB.User>();
        public UserBesines()
        {
            InitializeComponent();
            var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
            var userinf = from c in DBonWork.Users
                          select c;
            foreach (var x in userinf)
                dt.Add(x);
            dataGridView1.DataSource = dt;
        }

        private void modifay_Click(object sender, EventArgs e)
        {
            if (users.Text == string.Empty || users_name.Text == string.Empty || passward.Text == string.Empty || combodegre.Text == string.Empty)
            {
                MessageBox.Show("يجب ملئ جميع الحقول", "Erorr");
            }
            else
            {
                try
                {
                    var I = dataGridView1.CurrentRow.Index;
                    var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                    var userupdata = (from c in DBonWork.Users
                                      where c.ID.Equals(users.Text)
                                      select c).FirstOrDefault();
                    userupdata.Name = users_name.Text;
                    userupdata.Degre = combodegre.Text;
                    userupdata.PassWord = passward.Text;
                    DBonWork.SubmitChanges();
                    dt.RemoveAt(I);
                    dataGridView1.DataSource = null;
                    dt.Add(userupdata);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erorr");
                }
                users.Clear();
                users_name.Clear();
                passward.Clear();
                combodegre.Text = null;
            }
        }
        private void delet_Click(object sender, EventArgs e)
        {
            if (users.Text != string.Empty)
            {
                try
                {
                    var I = dataGridView1.CurrentRow.Index;
                    var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                    var userdelet = (from c in DBonWork.Users
                                     where c.ID.Equals(users.Text)
                                     select c).FirstOrDefault();
                    DBonWork.Users.DeleteOnSubmit(userdelet);
                    DBonWork.SubmitChanges();
                    dt.RemoveAt(I);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erorr");
                }
                users.Clear();
                users_name.Clear();
                passward.Clear();
                combodegre.Text = null;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            users.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            users_name.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            passward.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            combodegre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            users.Text = null;
            users_name.Text = null;
            passward.Text = null;
            combodegre.Text = null;
        }
    }
}
