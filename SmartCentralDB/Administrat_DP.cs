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
    public partial class Administrat_DP : Form
    {
        AddCabina fillcent = new AddCabina();
        PublicClass pr = new PublicClass();
        int num = 0;
        string ID_DP = "";
        public Administrat_DP()
        {
            InitializeComponent();
            if (Program.InfoCentralList.Count == 0)
                fillcent.fillinfocentral();
            foreach (var X in Program.InfoCentralList)
                ComboCentral.Items.Add(X.CentralName);
        }

        private void SerchAsStreet_Click(object sender, EventArgs e)
        {
            Main.SpareDPInfo.Clear();
            var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
            var selectdata = from p in DBonWork.Centrals
                             where p.IDcentral == num
                             from d in DBonWork.Cabels
                             where d.IDcentral == p.IDcentral
                             from c in DBonWork.Cabinas
                             where c.IDCable == d.IDCable
                             from T in DBonWork.DPs
                             where T.IDcabina == c.IDcabina && T.Area.Contains(Street.Text)
                             select new { p.CentralName, d.CableNumber, c.ODU, c.CABINA, d.PunctuationBG, d.PunctuationEN, T.Area, T.DPNumber, T.IDdp, T.DPGeneral };
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = selectdata;
            if (Main.SpareDPInfo.Count > 0)
                Main.SpareDPInfo.Clear();
            foreach (var item in selectdata)
                Main.SpareDPInfo.Add(item.IDdp, item.DPGeneral);
        }
        private void SerchAsDP_Click(object sender, EventArgs e)
        {
            int ID = pr.DPExisting(num.ToString() + ComboCabina.Text + ComboDP.Text);
            var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
            var selectdata = from p in DBonWork.DPs
                             where p.IDdp == ID
                             from B in DBonWork.Cabinas
                             where B.IDcabina == p.IDcabina
                             from D in DBonWork.Cabels
                             where D.IDCable == B.IDCable
                             from c in DBonWork.Centrals
                             where c.IDcentral == D.IDcentral
                             select new { c.CentralName, D.CableNumber, B.ODU, B.CABINA, p.DPNumber, p.Area, D.PunctuationBG, D.PunctuationEN };
            this.dataGridView1.DataSource = selectdata;
        }
        private void modifay_Click(object sender, EventArgs e)
        {
            try
            {
                var k = dataGridView1.CurrentRow.Index;
                int j = pr.DPExisting(num.ToString() + dataGridView1.CurrentRow.Cells[3].Value.ToString() + dataGridView1.CurrentRow.Cells[6].Value.ToString());
                if (j == 0)
                    j = pr.SpareDPExisting(num.ToString() + dataGridView1.CurrentRow.Cells[3].Value.ToString() + dataGridView1.CurrentRow.Cells[6].Value.ToString());
                pr.UpDataDP(j, area.Text);
                dataGridView1.Rows.RemoveAt(k);
                area.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void delet_Click(object sender, EventArgs e)
        {
            var k = dataGridView1.CurrentRow.Index;
            int l = 0;
            int j = pr.DPExisting(num.ToString() + dataGridView1.CurrentRow.Cells[3].Value.ToString() + dataGridView1.CurrentRow.Cells[6].Value.ToString());
            if (j == 0)
            {
                l = 1;
                j = pr.SpareDPExisting(num.ToString() + dataGridView1.CurrentRow.Cells[3].Value.ToString() + dataGridView1.CurrentRow.Cells[6].Value.ToString());
            }
            pr.DeletDP(j);
            dataGridView1.Rows.RemoveAt(k);
            if (l == 0)
            {
                for (int i = 0; i < ComboDP.Items.Count; i++)
                {
                    if (ComboDP.Items[i].ToString() == dataGridView1.CurrentRow.Cells[6].Value.ToString())
                    {
                        ComboDP.Items.RemoveAt(i);
                        break;
                    }
                }
            }
            area.Clear();
        }
        private void ComboCentral_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = pr.GetNumber(ComboCentral.Text);
            ComboCabina.Items.Clear();
            Main.CabinaInfo.Clear();
            var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
            var selectdata = (from p in DBonWork.Centrals
                              where p.IDcentral == num
                              from d in DBonWork.Cabels
                              where d.IDcentral == p.IDcentral
                              from c in DBonWork.Cabinas
                              where c.IDCable == d.IDCable
                              select new { c.IDcabina, c.CABINA, c.CabinaGeneral }).Distinct();
            var i = from c in selectdata
                    orderby c.CABINA ascending
                    select c;
            if (i.Count() > 0)
            {
                foreach (var X in i)
                {
                    Main.CabinaInfo.Add(X.IDcabina, X.CabinaGeneral);
                    ComboCabina.Items.Add(X.CABINA);
                }
            }
            Street.Focus();
        }
        private void ComboCabina_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboDP.Items.Clear();
            Main.DPInfo.Clear();
            int j = pr.CabinaExisting(num.ToString() + ComboCabina.Text);
            var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
            var SelecDP = from D in DBonWork.DPs
                          where D.IDcabina == j
                          select new { D.IDdp, D.DPGeneral, D.DPNumber };
            var i = from c in SelecDP
                    orderby c.DPNumber ascending
                    select c;
            if (i.Count() > 0)
                foreach (var item in SelecDP)
                {
                    ComboDP.Items.Add(item.DPNumber);
                    Main.DPInfo.Add(item.IDdp, item.DPGeneral);
                }
            var selectdata = from p in DBonWork.DPs
                             where p.IDcabina == j
                             from B in DBonWork.Cabinas
                             where B.IDcabina == p.IDcabina
                             from D in DBonWork.Cabels
                             where D.IDCable == B.IDCable
                             from c in DBonWork.Centrals
                             where c.IDcentral == D.IDcentral
                             select new { c.CentralName, D.CableNumber, B.ODU, B.CABINA, p.DPNumber, p.Area, D.PunctuationBG, D.PunctuationEN };
            var t = from c in selectdata
                    orderby c.DPNumber ascending
                    select c;
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = t;
            ComboDP.Focus();
        }
        private void ComboDP_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerchAsDP.Focus();
        }

        private void Street_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SerchAsStreet.Focus();
        }
        private void area_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                modifay.Focus();
        }

        private void Administrat_DP_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Main.SpareDPInfo.Count > 0)
                Main.SpareDPInfo.Clear();
        }
    }
}
