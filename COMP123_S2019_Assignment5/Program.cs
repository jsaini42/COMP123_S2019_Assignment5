using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5
{
    static class Program
    {
        public static Dictionary<FormName, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.SPLASH_SCREEN, new SplashScreen());
            Forms.Add(FormName.START_FORM, new StartForm());
            Application.Run(Forms[FormName.SPLASH_SCREEN]);
        }
    }
}
