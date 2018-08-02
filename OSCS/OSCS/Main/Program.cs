using OSCS.WinForms.Login;
using OSCS.WinForms.Registration;
using OSCS.WinForms.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSCS.WinForms.Fiddler;
using OSCS.WinForms.FileVirusChecker;

namespace OSCS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FiddlerCapture()); //change to name of window you want to run
        }
    }
}
