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
    public partial class Administrat_Cabina : Form
    {
        AddCabina fillcent = new AddCabina();
        List<DB.Central> MyCintral = new List<DB.Central>();
        List<DB.Central> MyCabel = new List<DB.Central>();
        List<DB.Central> MyCabina = new List<DB.Central>();
        PublicClass pr = new PublicClass();
        int Numcent = 0;
        int IDcabina = 0;

        public Administrat_Cabina()
        {
            InitializeComponent();
            if (Program.InfoCentralList.Count == 0)
                fillcent.fillinfocentral();
            foreach (var X in Program.InfoCentralList)
                ComboCentral.Items.Add(X.CentralName);
        }

        private void SerchAsArea_Click(object sender, EventArgs e)
        {
            if (ComboCentral.Text == string.Empty || Street.Text == string.Empty)
            {
                if (ComboCentral.Text == string.Empty)
                    MessageBox.Show("اختار السنترال", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (Street.Text == string.Empty)
                    MessageBox.Show("ادخل عنوان للبحث", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Numcent = pr.GetNumber(ComboCentral.Text);
                var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                var selectdata = from p in DBonWork.Centrals
                                 where p.IDcentral == Numcent
                                 from d in DBonWork.Cabels
                                 where d.IDcentral == p.IDcentral
                                 from c in DBonWork.Cabinas
                                 where c.IDCable == d.IDCable && c.Area.Contains(Street.Text)
                                 select new { p.CentralName, d.CableNumber, c.ODU, c.CABINA, c.Area, d.PunctuationBG, d.PunctuationEN };
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = selectdata;
            }
            Street.Clear();
        }
        private void SerchAsCabina_Click(object sender, EventArgs e)
        {
            if (ComboCentral.Text == string.Empty || ComboCabina.Text == string.Empty)
            {
                if (ComboCentral.Text == string.Empty)
                    MessageBox.Show("اختار السنترال", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (ComboCabina.Text == string.Empty)
                    MessageBox.Show("اختار الكابينة", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                var selectdata = from c in DBonWork.Cabinas
                                 where c.IDcabina == IDcabina
                                 from d in DBonWork.Cabels
                                 where d.IDCable == c.IDCable
                                 from p in DBonWork.Centrals
                                 where p.IDcentral == d.IDcentral
                                 select new { p.CentralName, d.CableNumber, c.ODU, c.CABINA, c.Area, d.PunctuationBG, d.PunctuationEN };
                this.dataGridView1.DataSource = selectdata;
            }
        }
        private void modifay_Click(object sender, EventArgs e)
        {
            try
            {
                var k = dataGridView1.CurrentRow.Index;
                if (area.Text != string.Empty)
                {
                    int i = pr.CabinaExisting(Numcent.ToString() + dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    pr.UpDataCabina(i, area.Text);
                    dataGridView1.Rows.RemoveAt(k);
                    area.Clear();
                }
            }
            catch (SqlException ex)
            {
                int err = ex.State;
                MessageBox.Show(err.ToString());
            }
            area.Clear();
        }
        private void UpData_Click(object sender, EventArgs e)
        {
            var k = dataGridView1.CurrentRow.Index;
            int u = 0;
            for (int i = 0; i < ComboCabina.Items.Count; i++)
            {
                if (ComboCabina.Items[i].ToString() == dataGridView1.CurrentRow.Cells[3].Value.ToString())
                {
                    u = i; break;
                }
            }
            AddCabina frm = new AddCabina();
            AddCabina.NumCentral = pr.GetNumber(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frm.CabinaCabel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.tetarea.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.combocent.Items.Clear();
            frm.combocent.Items.Add(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frm.combocent.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.Text = "تعديل بيانات الكبينة";
            frm.button1.Text = "تحديث";
            frm.CabinaCabel.ReadOnly = true;
            AddCabina.NumCabina = pr.CabinaExisting(Numcent.ToString() + dataGridView1.CurrentRow.Cells[3].Value.ToString());
            frm.ShowDialog();
            dataGridView1.Rows.RemoveAt(k);
            ComboCabina.Items.RemoveAt(u);
            area.Clear();
        }
        private void delet_Click(object sender, EventArgs e)
        {
            var k = dataGridView1.CurrentRow.Index;
            try
            {
                int j = pr.CabinaExisting(Numcent.ToString() + dataGridView1.CurrentRow.Cells[3].Value.ToString());
                pr.DeletCabina(j);
                dataGridView1.Rows.RemoveAt(k);
                for (int i = 0; i < ComboCabina.Items.Count; i++)
                {
                    if (ComboCabina.Items[i].ToString() == dataGridView1.CurrentRow.Cells[3].Value.ToString())
                    {
                        ComboCabina.Items.RemoveAt(i);
                        break;
                    }
                }
                area.Clear();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("الكبينة تحتوى على بيانات يجب حذفها اولا");
                else
                    MessageBox.Show(ex.ToString());
            }
            catch (Exception expt)
            {
                MessageBox.Show(expt.ToString());
            }
        }
        private void ComboCentral_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboCabina.Items.Clear();
            Numcent = pr.GetNumber(ComboCentral.Text);
            Main.CabinaInfo.Clear();
            var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
            var selectdata = (from p in DBonWork.Centrals
                              where p.IDcentral == Numcent
                              from d in DBonWork.Cabels
                              where d.IDcentral == p.IDcentral
                              from c in DBonWork.Cabinas
                              where c.IDCable == d.IDCable
                              select new { c.IDcabina, c.CABINA, c.CabinaGeneral }).Distinct();
            if (selectdata.Count() > 0)
            {
                foreach (var X in selectdata)
                {
                    Main.CabinaInfo.Add(X.IDcabina, X.CabinaGeneral);
                    ComboCabina.Items.Add(X.CABINA);
                }
            }
            Street.Focus();
        }

        private void ComboCabina_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDcabina = pr.CabinaExisting(Numcent.ToString() + ComboCabina.Text.Trim());
            SerchAsCabina.Focus();
        }

        private void Street_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SerchAsArea.PerformClick();
        }

        private void area_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                modifay.Focus();
        }
    }
}
