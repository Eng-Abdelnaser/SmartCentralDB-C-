using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCentralDB
{
    public partial class SettingPath : Form
    {
        public SettingPath()
        {
            InitializeComponent();
        }
        private void ButSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (WindowsAuttentication.Checked == true)
                {
                    Properties.Settings.Default.ConctToMaster = " Data Source='" + ServerName.Text + "';Integrated Security=True;";
                    Properties.Settings.Default.ConctToDataBase = "Data Source='" + ServerName.Text + "';Initial Catalog=SmartCentralDB;Integrated Security=True;";
                    var CreatDB = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                        LogIn frm = new LogIn();
                        frm.ShowDialog();
                        if (Program.UserDgre == true)
                        {
                            Properties.Settings.Default.Save();
                            ProcessStartInfo startInfo = new ProcessStartInfo();
                            startInfo.FileName = @"E:\لغات برمجه\Codes\C#\Applications\Contracts\Contracts\bin\Debug\Contracts.exe";
                            startInfo.Arguments = "SmartCentralDB_Modify WindowsAuttent "+ ServerName.Text;
                            Process.Start(startInfo);
                        }
                        else
                            MessageBox.Show("المستخدم الذى ادخلته لايملك صلاحية تغير اعدادات الاتصال بالسيرفر");
                }
                else {
                    Properties.Settings.Default.ConctToMaster = " Data Source='" + ServerName.Text.Trim() + "'Integrated Security= false;Uesr ID=" +
                                                 UserNameAutt.Text.Trim() + "';Password='" + PassWordAutt.Text.Trim() + "';";
                    Properties.Settings.Default.ConctToDataBase = "Data Source='" + ServerName.Text + "';Initial Catalog=SmartCentralDB;Integrated Security= false;Uesr ID=" +
                                                 UserNameAutt.Text.Trim() + "';Password='" + PassWordAutt.Text.Trim() + "';";
                    var CreatDB = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
                        LogIn frm = new LogIn();
                        frm.ShowDialog();
                        if (Program.UserDgre == true)
                        {
                            Properties.Settings.Default.Save();
                            ProcessStartInfo startInfo = new ProcessStartInfo();
                            startInfo.FileName = @"E:\لغات برمجه\Codes\C#\Applications\Contracts\Contracts\bin\Debug\Contracts.exe";
                            startInfo.Arguments = "SmartCentralDB_Modify SQLServerAuttent " + ServerName.Text+
                                                    " "+ UserNameAutt.Text+" "+ PassWordAutt;
                            Process.Start(startInfo);
                        }
                        else
                            MessageBox.Show("المستخدم الذى ادخلته لايملك صلاحية تغير اعدادات الاتصال بالسيرفر");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erorr");
            }
            ServerName.Clear();
            UserNameAutt.Clear();
            PassWordAutt.Clear();
        }
        private void butclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void WindowsAuttentication_CheckedChanged(object sender, EventArgs e)
        {
            if (WindowsAuttentication.Checked == true)
            {
                UserNameAutt.ReadOnly = true;
                PassWordAutt.ReadOnly = true;
            }
        }
        private void SQLServerAuttentication_CheckedChanged(object sender, EventArgs e)
        {
            if (SQLServerAuttentication.Checked == true)
            {
                UserNameAutt.ReadOnly = false;
                PassWordAutt.ReadOnly = false;
            }
        }
    }
}
