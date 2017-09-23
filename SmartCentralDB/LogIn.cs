using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SmartCentralDB
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            var DBonWork = new DB.SmartCentralDB(Properties.Settings.Default.ConctToDataBase);
            var SelecUser = (from user in DBonWork.Users
                             where user.ID == ID.Text
                             select user.Degre).Take(1);
            if (SelecUser.Count() == 0)
            {
                MessageBox.Show("اسم المستخدم او كلمة السر غير صحيحة");
                return;//يقوم بالعودة الى نفس الفورم الحالى عندما يكون شرط الدالة صحيح ولايكمل باقى الكود
            }
            else
            {
                if (SelecUser.Contains("مدير"))
                {
                    Program.UserDgre = true;
                    this.Close();    //يقوم بالخروج عند تسجيل بيانات صحيحة
                }
                else
                {
                    Program.UserDgre = false;
                    this.Close();
                }
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Pass.Focus();
        }
        private void Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Insert.Focus();
        }
    }
}
/*
                     pr.InsertQury(@"Create Proc Update_Cabinas
                                         @IDcabina int ,@IDCable int ,@CabinaGeneral nvarchar(30), @Area nvarchar(200),@ODU nvarchar(10)
                                           as
                                    UPDATE [dbo].[Cabinas]
                                   SET Area=@Area,CabinaGeneral=@CabinaGeneral,IDCable=@IDCable,ODU=@ODU
                                    WHERE IDcabina=@IDcabina  ;");
                    pr.InsertQury(@"Create Proc [dbo].[UpdateDP]
                                            @IDdp int ,@Area nvarchar(200)
                                                 as
                                         UPDATE [dbo].[DPs]
                                         SET Area=@Area
                                         WHERE IDdp=@IDdp ;");
                    pr.InsertQury(@"Create Proc [dbo].UpDataCabina
                                           @ID int ,@Area nvarchar(200)
                                                 as
                                         UPDATE [dbo].[Cabinas]
                                         SET Area=@Area
                                          WHERE IDcabina=@ID  ;");
                    pr.InsertQury(@"Create Proc DeletDP
                                               @ID int
                                               as
                                          DELETE FROM [dbo].[DPs]
                                         WHERE IDdp=@ID  ;");
                    pr.InsertQury(@"Create Proc DeletCabina
                                             @ID int
                                                  as
                                             DELETE FROM [dbo].[Cabinas]
                                               WHERE IDcabina=@ID   ;");
                    pr.InsertQury(@"CREATE Proc [dbo].[CreateBakUp]
                                             @PathBak nvarchar(200)
                                              as
                                              Backup Database SmartCentralDB to Disk = @PathBak;");

     */
