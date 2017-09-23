using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SmartCentralDB
{
    public partial class Administrat_Central : Form
    {
        PublicClass pr = new PublicClass();
        AddCabina fillcet = new AddCabina();
        List<DB.Cabel> ListCabel = new List<DB.Cabel>();
        public enum KIND { Copper = 1, Msan = 2 }
        public int num = 0;
        int vrify(string ID)
        {
            try
            {
                var j = (from c in ListCabel
                         where c.CabelGenral == ID
                         select c.IDCable).FirstOrDefault();
                if (j > 0)
                    return j;
                else
                    return 0;
            }
            catch (ArgumentNullException)
            {
                return 0;
            }
        }
        public Administrat_Central()
        {
            InitializeComponent();
            if (Program.InfoCentralList.Count == 0)
                fillcet.fillinfocentral();
            groupBox5.Size = new System.Drawing.Size(0, 0);
            this.dataGridView1.DataSource = Program.InfoCentralList;
            comboBox2.DataSource = Enum.GetValues(typeof(KIND));
            foreach (var item in Program.InfoCentralList)
                comboBox1.Items.Add(item.CentralName);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (CenteralToSave.Text != string.Empty)
            {
                var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                DB.Central SaveCentral = new DB.Central { CentralName = CenteralToSave.Text.Trim() };
                DBonWork.Centrals.InsertOnSubmit(SaveCentral);
                DBonWork.SubmitChanges();
                var newcentral = (from c in DBonWork.Centrals
                                  where c.CentralName.Equals(CenteralToSave.Text)
                                  select c).FirstOrDefault();
                Program.InfoCentralList.Add(newcentral);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = Program.InfoCentralList;
                comboBox1.Items.Add(CenteralToSave.Text);
                CenteralToSave.Clear();
                CenteralToSave.Focus();
            }
            else
                CenteralToSave.Focus();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                num = pr.GetNumber(CellactCentral.Text);
                var k = dataGridView1.CurrentRow.Index;
                var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                var deletcent = (from c in DBonWork.Centrals
                                 where c.IDcentral.Equals(num)
                                 select c).FirstOrDefault();
                DBonWork.Centrals.DeleteOnSubmit(deletcent);
                DBonWork.SubmitChanges();
                Program.InfoCentralList.RemoveAt(k);
                comboBox1.Items.Clear();
                foreach (var item in Program.InfoCentralList)
                    comboBox1.Items.Add(item.CentralName);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = Program.InfoCentralList;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("السنترال يحتوى على بيانات يجب حذفهااولا");
                else
                    MessageBox.Show(ex.ToString());
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
            finally
            {
                CellactCentral.Clear();
                ModifyCentral.Clear();
            }
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            if (ModifyCentral.Text != string.Empty)
            {
                try
                {
                    num = pr.GetNumber(CellactCentral.Text);
                    var k = dataGridView1.CurrentRow.Index;
                    var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                    var updatacent = (from c in DBonWork.Centrals
                                      where c.IDcentral.Equals(num)
                                      select c).FirstOrDefault();
                    updatacent.CentralName = ModifyCentral.Text;
                    DBonWork.SubmitChanges();
                    Program.InfoCentralList.RemoveAt(k);
                    Program.InfoCentralList.Add(updatacent);
                    this.dataGridView1.DataSource = null;
                    this.dataGridView1.DataSource = Program.InfoCentralList;
                    comboBox1.Items.Clear();
                    foreach (var item in Program.InfoCentralList)
                        comboBox1.Items.Add(item.CentralName);
                    CellactCentral.Clear();
                    ModifyCentral.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                MessageBox.Show("ادخل اسم السنترال");
        }

        private void SaveCabel_Click(object sender, EventArgs e)
        {
            if (textBox1.ReadOnly != true)
            {
                string ID =comboBox2.Text == KIND.Copper.ToString() ? textBox1.Text : ("M" + textBox1.Text);
                if( vrify(num.ToString()+ ID) == 0)
                {
                    var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                    DB.Cabel CabelInsert = new DB.Cabel { IDcentral = num, CableNumber = ID, CabelGenral = num.ToString() + ID, PunctuationBG = textBox2.Text, PunctuationEN = textBox3.Text };
                    DBonWork.Cabels.InsertOnSubmit(CabelInsert);
                    DBonWork.SubmitChanges();
                    var newcabel = (from c in DBonWork.Cabels
                                    where c.IDcentral == num && c.CableNumber == ID
                                    select c).FirstOrDefault();
                    ListCabel.Add(newcabel);
                    groupBox5.Size = new System.Drawing.Size(0, 0);
                    comboBox2.Text = KIND.Copper.ToString();
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = ListCabel;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox1.Focus();
                    textBox1.SelectionStart = 0;
                    textBox1.SelectionLength = textBox1.Text.Length;
                }
                else
                {
                    MessageBox.Show("هذا الكابل من ضمن كابلات السنترال الحالى");
                    textBox1.Focus();
                    textBox1.SelectionStart = 0;
                    textBox1.SelectionLength = textBox1.Text.Length;
                }
            }
        }

        private void ModifyCabel_Click(object sender, EventArgs e)
        {
            if (textBox1.ReadOnly == true)
            {
                var k = dataGridView2.CurrentRow.Index;
                string x = textBox2.Text, y = textBox3.Text;
                int b = vrify(num.ToString() + dataGridView2.CurrentRow.Cells[0].Value.ToString());
                if (dataGridView2.CurrentRow.Cells[1].Value.ToString() != x || dataGridView2.CurrentRow.Cells[2].Value.ToString() != y)
                {
                    var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                    var UpdatCabel = (from c in DBonWork.Cabels
                                      where c.IDCable.Equals(b)
                                      select c).FirstOrDefault();
                    UpdatCabel.PunctuationBG = x;
                    UpdatCabel.PunctuationEN = y;
                    DBonWork.SubmitChanges();
                    ListCabel.RemoveAt(k);
                    dataGridView2.DataSource = null;
                    ListCabel.Add(UpdatCabel);
                    dataGridView2.DataSource = ListCabel;
                }
                groupBox5.Size = new System.Drawing.Size(0, 0);
                comboBox2.Text = KIND.Copper.ToString();
                textBox1.Clear();
                textBox1.ReadOnly = false;
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void DeletCabel_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.ReadOnly == true)
                {
                    int k = dataGridView2.CurrentRow.Index;
                    int b = vrify(num.ToString() + dataGridView2.CurrentRow.Cells[0].Value.ToString());
                    var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                    var deletcabel = (from c in DBonWork.Cabels
                                      where c.IDCable.Equals(b)
                                      select c).FirstOrDefault();
                    DBonWork.Cabels.DeleteOnSubmit(deletcabel);
                    DBonWork.SubmitChanges();
                    ListCabel.RemoveAt(k);
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = ListCabel;
                    groupBox5.Size = new System.Drawing.Size(0, 0);
                    textBox1.ReadOnly = false;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("الكابل يحتوى على بيانات يجب حذفهااولا");
                else
                    MessageBox.Show(ex.ToString());
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void CenteralToSave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Save.Focus();
        }

        private void CenteralToSave_Validated(object sender, EventArgs e)
        {
            if (CenteralToSave.Text != string.Empty)
            {
                if (pr.GetNumber(CenteralToSave.Text) > 0)
                {
                    MessageBox.Show("السنترال موجود");
                    CenteralToSave.Focus();
                    CenteralToSave.Clear();
                }
            }
        }

        private void ModifyCentral_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Modify.Focus();
        }

        private void ModifyCentral_Validated(object sender, EventArgs e)
        {
            if (ModifyCentral.Text != string.Empty)
            {
                if (pr.GetNumber(ModifyCentral.Text) > 0)
                {
                    MessageBox.Show("هذاالسنترال موجود");
                    CellactCentral.Clear();
                    ModifyCentral.Clear();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CellactCentral.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            CellactCentral.Clear();
            ModifyCentral.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = pr.GetNumber(comboBox1.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            ListCabel.Clear();
            var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
            var SelectCabl = (from c in DBonWork.Cabels
                              where c.IDcentral == num
                              select c).Distinct();
            foreach (var x in SelectCabl)
                ListCabel.Add(x);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = ListCabel;
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (SaveCabel.Text == "اضافة")
            {
                if ((e.KeyChar == (Char)Keys.M) || (e.KeyChar == 109))
                    e.Handled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                comboBox2.Focus();
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboBox2.Text == KIND.Copper.ToString())
                    SaveCabel.Focus();
                else
                    textBox2.Focus();
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == KIND.Msan.ToString())
            {
                groupBox5.Size = new System.Drawing.Size(322, 53);
                textBox2.Focus();
            }
            else
            {
                groupBox5.Size = new System.Drawing.Size(0, 0);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox3.Focus();
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SaveCabel.Focus();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow.Cells[0].Value.ToString().Contains("M"))
            {
                comboBox2.Text = KIND.Msan.ToString();
                groupBox5.Size = new System.Drawing.Size(322, 53);
                textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                comboBox2.Text = KIND.Copper.ToString();
                groupBox5.Size = new System.Drawing.Size(0, 0);
            }
            textBox1.ReadOnly = true;
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ReadOnly = false;
            textBox2.Clear();
            textBox3.Clear();
            groupBox5.Size = new System.Drawing.Size(0, 0);
            comboBox2.Text = KIND.Copper.ToString();
        }
    }
}
