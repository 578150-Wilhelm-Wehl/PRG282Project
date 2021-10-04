using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282Project.Presentation;
using System.IO;
using System.Threading;


namespace PRG282Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string UserFilePath = @Directory.GetCurrentDirectory() + "/ActiveUsers.txt";
            if (!File.Exists(UserFilePath))
            {
                var fs = File.CreateText(UserFilePath);
                fs.Close();
                StreamWriter sw = new StreamWriter(UserFilePath);
                sw.WriteLine("Admin-Admin-N/A-N/A");
                sw.Close();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
