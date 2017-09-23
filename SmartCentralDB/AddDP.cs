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
    public partial class AddDP : Form
    {
        PublicClass pr = new PublicClass();
        AddCabina fillcent = new AddCabina();
        List<string> MyList = new List<string>();
        int Numcent = 0;
        int Numcabina = 0;
        string CentralName = "";
        bool vrify(string strDP)
        {
            bool b = false;
            try
            {
                var j = (from c in MyList
                         where c.Equals(strDP)
                         select c).FirstOrDefault();
                if (j.Count() > 0)
                    b = true;
                return b;
            }
            catch (ArgumentNullException)
            {
                return b;
            }
        }
        public AddDP()
        {
            InitializeComponent();
            if (Program.InfoCentralList.Count == 0)
                fillcent.fillinfocentral();
            foreach (var X in Program.InfoCentralList)
                ComboCentral.Items.Add(X.CentralName);
        }

        private void ComboCentral_SelectedIndexChanged(object sender, EventArgs e)
        {
            Numcent = pr.GetNumber(ComboCentral.Text);
            if (ComboCentral.Text != CentralName)
            {
                ComboCabina.Items.Clear();
                CentralName = ComboCentral.Text;
                Main.CabinaInfo.Clear();
                var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                var SelecCabel = (from D in DBonWork.Cabels
                                  where D.IDcentral == Numcent
                                  from c in DBonWork.Cabels
                                  where c.IDcentral == D.IDcentral
                                  from P in DBonWork.Cabinas
                                  where P.IDCable == c.IDCable
                                  select new { P.IDcabina, P.CABINA });
                if (SelecCabel.Count() > 0)
                    foreach (var X in SelecCabel.Distinct())
                    {
                        ComboCabina.Items.Add(X.CABINA);
                        Main.CabinaInfo.Add(X.IDcabina, X.CABINA);
                    }
            }

        }

        private void ComboCabina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Numcabina = pr.CabinaExisting(ComboCabina.Text);
            MyList.Clear();
            var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
            var SelecDP = (from D in DBonWork.DPs
                           where D.IDcabina == Numcabina
                           select D.DPNumber).Distinct();
            if (SelecDP.Count() > 0)
                foreach (var item in SelecDP)
                    MyList.Add(item);
            DPNumber.Focus();

        }

        private void SaveBt_Click(object sender, EventArgs e)
        {

              if (ComboCentral.Text == string.Empty || ComboCabina.Text == string.Empty || DPNumber.Text == string.Empty || AreaDP.Text == string.Empty)
                {
                    if (ComboCentral.Text == string.Empty)
                        MessageBox.Show("اختار السنترال", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (ComboCabina.Text == string.Empty)
                        MessageBox.Show("اختار الكابينة", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (DPNumber.Text == string.Empty)
                        MessageBox.Show("حدد رقم البكس", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (AreaDP.Text == string.Empty)
                        MessageBox.Show("ادخل عنوان البكس", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        string dpGeneral = Numcent.ToString() + ComboCabina.Text + DPNumber.Text;
                        var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                        DB.DP SaveDP = new DB.DP
                        {
                            IDcabina = Numcabina,
                            Area = AreaDP.Text.Trim(),
                            DPNumber = DPNumber.Text.Trim(),
                            DPGeneral = dpGeneral
                        };
                        DBonWork.DPs.InsertOnSubmit(SaveDP);
                        DBonWork.SubmitChanges();
                        MyList.Add(DPNumber.Text.Trim());
                        AreaDP.Clear();
                        DPNumber.Clear();
                        DPNumber.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        private void DPNumber_Validated(object sender, EventArgs e)
        {
            if (ComboCentral.Text == string.Empty || ComboCabina.Text == string.Empty || DPNumber.Text == string.Empty)
                ComboCentral.Focus();
            else
            {
                if (vrify(pr.ReturnUpperString(DPNumber.Text)))
                {
                    MessageBox.Show("البكس موجود بالفعل", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DPNumber.Clear();
                    DPNumber.Focus();
                }
                else
                    AreaDP.Focus();
            }
        }

        private void DPNumber_KeyDown(object sender, KeyEventArgs e)
        {
         if (e.KeyCode == Keys.Enter)
            {
                if (ComboCentral.Text == string.Empty || ComboCabina.Text == string.Empty || DPNumber.Text == string.Empty)
                    ComboCentral.Focus();
                else
                {
                    if (vrify(pr.ReturnUpperString(DPNumber.Text)))
                    {
                        MessageBox.Show("البكس موجود بالفعل", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DPNumber.Clear();
                        DPNumber.Focus();
                    }
                    else
                        AreaDP.Focus();
                }
            }
        }

        private void AreaDP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SaveBt.Focus();
        }
    }
}
