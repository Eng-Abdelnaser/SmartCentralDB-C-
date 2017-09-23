using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
namespace SmartCentralDB
{
    class PublicClass
    {

        public void CreateStoredProcedure(string qury)
        {
            SqlConnection sqlconnection = new SqlConnection(Properties.Settings.Default.ConctToDataBase);
            SqlCommand cmd = new SqlCommand(qury, sqlconnection);
            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
        }
        public void InsertQury(string Query)
        {
            SqlConnection connc = new SqlConnection(Properties.Settings.Default.ConctToDataBase);
            SqlCommand comm;
            if (connc.State == ConnectionState.Open)
                connc.Close();
            comm = new SqlCommand(Query, connc);
            connc.Open();
            comm.ExecuteNonQuery();
            connc.Close();
        }
        public void Update_Cabinas(int IDcabina, int IDCable, string Area, string ODU)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@IDcabina", SqlDbType.Int);
            param[0].Value = IDcabina;
            param[1] = new SqlParameter("@IDCable", SqlDbType.Int);
            param[1].Value = IDCable;
            param[2] = new SqlParameter("@Area", SqlDbType.NVarChar, 200);
            param[2].Value = Area;
            param[3] = new SqlParameter("@ODU ", SqlDbType.NVarChar, 10);
            param[3].Value = ODU;
            DAL.ExecuteCommand("Update_Cabinas", param);
            DAL.close();
        }
        public void DeletDP(int ID)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            DAL.ExecuteCommand("DeletDP", param);
            DAL.close();
        }
        public void DeletCabina(int ID)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            DAL.ExecuteCommand("DeletCabina", param);
            DAL.close();
        }
        public void UpDataCabina(int ID, string area)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@Area", SqlDbType.NVarChar, 200);
            param[1].Value = area;
            DAL.ExecuteCommand("UpDataCabina", param);
            DAL.close();
        }
        public void UpDataDP(int ID, string area)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@IDdp", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@Area", SqlDbType.NVarChar, 200);
            param[1].Value = area;
            DAL.ExecuteCommand("UpdateDP", param);
            DAL.close();
        }
        public void CreateBakUp(string PathBak)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@PathBak", SqlDbType.NVarChar, 200);
            param[0].Value = PathBak;
            DAL.ExecuteCommand("CreateBakUp", param);
            DAL.close();
        }
        public int GetNumber(string Name)
        {
            try
            {
                int j = 0;
                DataTable DT = new DataTable();
                DataColumn id = new DataColumn("id", typeof(short));
                DataColumn name = new DataColumn("name", typeof(string));
                DT.Columns.Add(id);
                DT.Columns.Add(name);
                var GetInfoCent = from c in Program.InfoCentralList
                                  where c.CentralName.Equals(Name)
                                  select c;
                foreach (var item in GetInfoCent)
                    DT.Rows.Add(new object[] { item.IDcentral, item.CentralName });
                return j = Convert.ToInt32(DT.Rows[0]["id"].ToString());
            }
            catch (NullReferenceException)
            {
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int CabinaExisting(string ID)
        {
            try
            {
                int j = 0;
                foreach (DictionaryEntry item in Main.CabinaInfo)
                {
                    if ((string)item.Value == ID)
                    { j = (int)item.Key; break; }
                }
                return j;
            }
            catch (ArgumentNullException)
            {
                return 0;
            }
        }
        public int CabelExisting(string ID)
        {
            try
            {
                int j = 0;
                foreach (DictionaryEntry item in Main.CabelInfo)
                {
                    if ((string)item.Value == ID)
                    { j = (int)item.Key; break; }
                }
                return j;
            }
            catch (ArgumentNullException)
            {
                return 0;
            }

        }
        public int DPExisting(string ID)
        {
            try
            {
                int j = 0;
                foreach (DictionaryEntry item in Main.DPInfo)
                {
                    if ((string)item.Value == ID)
                    { j = (int)item.Key; break; }
                }
                return j;
            }
            catch (ArgumentNullException)
            {
                return 0;
            }
        }
        public int SpareDPExisting(string ID)
        {
            try
            {
                int j = 0;
                foreach (DictionaryEntry item in Main.SpareDPInfo)
                {
                    if ((string)item.Value == ID)
                    { j = (int)item.Key; break; }
                }
                return j;
            }
            catch (ArgumentNullException)
            {
                return 0;
            }
        }
        public string ReturnUpperString(string str_convert)
        {
          string s ="";
          for (int i = 0; i < str_convert.Length; i++)
          {
              if (Char.IsLower(str_convert[i]))
                  s += Char.ToUpper(str_convert[i]);
              else
                  s += str_convert[i];
          }
          return s;
        }
    }
}
