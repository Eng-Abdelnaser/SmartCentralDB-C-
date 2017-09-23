using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCentralDB
{
    class CreateProc
    {
        public static string[] createproctural = new string[] {
         @"Create Proc Update_Cabinas
                                     @IDcabina int ,@IDCable int ,@CabinaGeneral nvarchar(30), @Area nvarchar(200),@ODU nvarchar(10)
                                     as
                                     UPDATE [dbo].[Cabinas]
                                     SET Area=@Area,CabinaGeneral=@CabinaGeneral,IDCable=@IDCable,ODU=@ODU
                                     WHERE IDcabina=@IDcabina  ;",
          @"Create Proc [dbo].[UpdateDP]
                                      @IDdp int ,@Area nvarchar(200)
                                                 as
                                      UPDATE [dbo].[DPs]
                                      SET Area=@Area
                                      WHERE IDdp=@IDdp ;",
       @"Create Proc [dbo].UpDataCabina
                                       @ID int ,@Area nvarchar(200)
                                                 as
                                       UPDATE [dbo].[Cabinas]
                                       SET Area=@Area
                                       WHERE IDcabina=@ID  ;",
       @"Create Proc DeletDP
                                       @ID int
                                       as
                                       DELETE FROM [dbo].[DPs]
                                       WHERE IDdp=@ID  ;",
       @"Create Proc DeletCabina
                                       @ID int
                                       as
                                       DELETE FROM [dbo].[Cabinas]
                                       WHERE IDcabina=@ID   ;",
        @"CREATE Proc [dbo].[CreateBakUp]
                                        @PathBak nvarchar(200)
                                        as
                                        Backup Database SmartCentralDB to Disk = @PathBak;" };
    }
}
