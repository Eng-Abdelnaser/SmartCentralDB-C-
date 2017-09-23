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
    public partial class CreateBakUp : Form
    {
        SqlConnection sqlconnection = new SqlConnection(Properties.Settings.Default.ConctToDataBase);
        SqlCommand cmd;
        PublicClass pr = new PublicClass();
        public CreateBakUp()
        {
            InitializeComponent();
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBD.ShowDialog() == DialogResult.OK)
            {
                FolderPath.Text = folderBD.SelectedPath;
            }
        }
        private void CreatBakUp_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = FolderPath.Text + @"/SmartCentralDB" + " " + DateTime.Now.ToShortDateString().Replace('/', '-') + " " + DateTime.Now.ToShortTimeString().Replace(':', '-') + @".bak;";
                //string StrQuery = "Backup Database SmartCentralDB to Disk ='"+filename+"'.bak;";
                pr.CreateBakUp(filename);
                MessageBox.Show("تم انشاء النسخة الاحتياطية بنجاح", "انشاء النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
