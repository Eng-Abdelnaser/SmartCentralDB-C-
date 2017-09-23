using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCentralDB
{
    static class Program
    {
        public static bool UserDgre;
        public static int IDCabinaOld = 0;
        public static string cent = "";
        public static List<DB.Central> InfoCentralList = new List<DB.Central>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
