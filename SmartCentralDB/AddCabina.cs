using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SmartCentralDB
{
    public partial class AddCabina : Form
    {
        /// <summary>
        /// form to add address of cabina 
        /// pr field for manig 
        /// </summary>
        PublicClass pr = new PublicClass();
        List<string> MyList = new List<string>();
        public static int NumCentral = 0;
        public int NumCabel = 0;
        public static int NumCabina = 0;
        public string CentrlName = "";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name_Cabina"></param>
        /// <returns></returns>
        bool vrify(string Name_Cabina)
        {
            bool b = false;
            try
            {
                var j = (from c in MyList
                         where c.Equals(NumCentral.ToString() + Name_Cabina)
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
        public void fillinfocentral()
        {
            try
            {
                var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                var SelectCentral = from c in DBonWork.Centrals select c;
                foreach (var item in SelectCentral)
                    Program.InfoCentralList.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public AddCabina()
        {
            InitializeComponent();////12; 12
            groupBox1.Size = new System.Drawing.Size(0, 0);
           
            ODU.Size = new System.Drawing.Size(0, 0);
            label6.Text = "";
            if (Program.InfoCentralList.Count == 0)
                fillinfocentral();
            foreach (var item in Program.InfoCentralList)
                combocent.Items.Add(item.CentralName);
        }
        private void combocent_SelectedIndexChanged(object sender, EventArgs e)
        {
            NumCentral = pr.GetNumber(combocent.Text);
            if (combocent.Text != CentrlName)
            {
                CentrlName = combocent.Text;
                Main.CabelInfo.Clear();
                ComboType.Items.Clear();
                MyList.Clear();
                var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                var SelectAllCabel = (from c in DBonWork.Cabels
                                      where c.IDcentral == NumCentral
                                      select new { c.IDCable, c.CableNumber });
                foreach (var item in SelectAllCabel)
                {
                    Main.CabelInfo.Add(item.IDCable, item.CableNumber);
                    ComboType.Items.Add(item.CableNumber);
                }
                var j = from c in DBonWork.Cabels
                        where c.IDcentral == NumCentral
                        from p in DBonWork.Cabinas
                        where p.IDCable == c.IDCable
                        select p.CabinaGeneral;
                foreach (var item in j)
                    MyList.Add(item);
            }
            if (button1.Text == "حفظ")
                CabinaCabel.Clear();
            label6.Text = "";
            ODU.Clear();
            ComboType.Focus();

        }

        private void ComboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            NumCabel = pr.CabelExisting(ComboType.Text.Trim());
            if (ComboType.Text.Contains("M"))
            {
                ODU.Size = new System.Drawing.Size(51, 20);
                label6.Text = "ODU";
                label5.Text = "Msan";
                ODU.Clear();
                ODU.Focus();
            }
            else
            {
                ODU.Clear();
                ODU.Size = new System.Drawing.Size(0, 0);
                label6.Text = "";
                label5.Text = "كابل";
                CabinaCabel.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
            try
            {
                if (button1.Text == "حفظ")
                {
                    if (combocent.Text == string.Empty || ComboType.Text == string.Empty || CabinaCabel.Text == string.Empty || tetarea.Text == string.Empty)
                    {
                        MessageBox.Show("يجب ملئ الحقول اولا", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        combocent.Focus();
                    }
                    else
                    {
                        DB.Cabina SaveCabina = new DB.Cabina
                        {
                            IDCable = NumCabel,
                            CABINA = CabinaCabel.Text,
                            Area = tetarea.Text.Trim(),
                            CabinaGeneral = NumCentral.ToString() + CabinaCabel.Text,
                            ODU = ODU.Text
                        };
                        DBonWork.Cabinas.InsertOnSubmit(SaveCabina);
                        DBonWork.SubmitChanges();
                        MyList.Add(NumCentral.ToString() + CabinaCabel.Text);
                        tetarea.Clear();
                        CabinaCabel.Focus();
                        CabinaCabel.SelectionStart = 0;
                        CabinaCabel.SelectionLength = CabinaCabel.Text.Length;
                    }
                }
                if (button1.Text == "تحديث")
                {
                    NumCabel = pr.CabelExisting(ComboType.Text);
                    pr.Update_Cabinas(NumCabina, NumCabel, tetarea.Text, ODU.Text);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ComboType.Text != string.Empty)
            {
                NumCabel = pr.CabelExisting(NumCentral.ToString() + ComboType.Text);
                if (ComboType.Text.Contains("M"))
                {
                    ODU.Size = new System.Drawing.Size(51, 20);
                    label6.Text = "ODU";
                    label5.Text = "Msan";
                    ODU.Focus();
                }
                else
                {
                    ODU.Size = new System.Drawing.Size(0, 0);
                    label6.Text = "";
                    label5.Text = "كابل";
                    CabinaCabel.Focus();
                }

            }
        }

        private void ODU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CabinaCabel.Focus();
        }

        private void CabinaCabel_Validated(object sender, EventArgs e)
        {
            if (button1.Text == "حفظ")
            {
                if (combocent.Text == string.Empty || CabinaCabel.Text == string.Empty || ComboType.Text == string.Empty)
                {
                    combocent.Focus();
                }
                else
                {
                    if (vrify(pr.ReturnUpperString(CabinaCabel.Text)))
                    {
                        MessageBox.Show("الكبينة موجودة بالفعل", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CabinaCabel.Focus();
                        CabinaCabel.SelectionStart = 0;
                        CabinaCabel.SelectionLength = CabinaCabel.Text.Length;
                    }
                    else tetarea.Focus();
                }
            }
        }
        private void tetarea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1.Focus();
        }

        private void CabinaCabel_KeyDown(object sender, KeyEventArgs e)
        {
          if (e.KeyCode == Keys.Enter)
          {
              if (button1.Text == "حفظ")
              {
                  if (combocent.Text == string.Empty || CabinaCabel.Text == string.Empty || ComboType.Text == string.Empty)
                  {
                      combocent.Focus();
                  }
                  else
                  {
                      if (vrify(pr.ReturnUpperString(CabinaCabel.Text)))
                      {
                          MessageBox.Show("الكبينة موجودة بالفعل", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                          CabinaCabel.Focus();
                          CabinaCabel.SelectionStart = 0;
                          CabinaCabel.SelectionLength = CabinaCabel.Text.Length;
                      }
                      else tetarea.Focus();
                  }
              }
          }
        }

        private void AddCabina_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyList.Clear();
            if (button1.Text == "حفظ")
                Main.CabelInfo.Clear();
        }
    }
}
