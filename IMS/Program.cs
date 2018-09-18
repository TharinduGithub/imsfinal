using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMS.Models.Contexts;
using IMS.Models;


namespace IMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static bool IsAuthenticated;
        public static string UserRoll;
        public static string User;
        public static int UserID;
        public static int ErrorCode = 0;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

    }

}
