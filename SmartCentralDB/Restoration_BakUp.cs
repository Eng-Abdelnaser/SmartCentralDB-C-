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
    public partial class Restoration_BakUp : Form
    {
        SqlConnection sqlconnection = new SqlConnection(Properties.Settings.Default.ConctToMaster);
        SqlCommand cmd;
        public Restoration_BakUp()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textfilename.Text = openFileDialog1.FileName;
            }
        }
        private void create_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlconnection.State == ConnectionState.Open)
                    sqlconnection.Close();
                string StrQuery = "ALTER Database SmartCentralDB SET OFFLINE WITH ROLLBACK IMMEDIATE ;Restore Database SmartCentralDB from Disk='" + textfilename.Text + "'";
                cmd = new SqlCommand(StrQuery, sqlconnection);
                sqlconnection.Open();
                cmd.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("تم استعادة النسخة المحفوظه بنجاح اغلق البرنامج ثم اعد تشغيله ", "استعادة النسخة المحفوظه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (sqlconnection.State == ConnectionState.Open)
                    sqlconnection.Close();
                string StrQuery = "ALTER Database SmartCentralDB SET ONLINE;";
                cmd = new SqlCommand(StrQuery, sqlconnection);
                sqlconnection.Open();
                cmd.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show(ex.Message, "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
