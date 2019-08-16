using COMP123_S2019_Assignment5.Models;
using COMP123_S2019_Assignment5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* 
 *          App name: Dollar Computers
       Author's name: Jaspinder singh Saini
          Student ID: 301044893
   App Creation Date: Aug 1,2019
     App description: This app allow the user to choose computer by its system configuration preferences and can save order 
                       and load previous order and can even change their choices .
 */
namespace COMP123_S2019_Assignment5
{
    public static class Program
    {
        public static Product product;
        public static Dictionary<FormName, Form> Forms;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            product = new Product();
            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.SPLASH_SCREEN, new SplashScreen());
            Forms.Add(FormName.START_FORM, new StartForm());
            Forms.Add(FormName.SELECT_FORM, new SelectForm());
            Forms.Add(FormName.PRODUCTINFO_FORM, new ProductInfoForm());
            Forms.Add(FormName.ORDER_FORM, new OrderForm());
            Forms.Add(FormName.ABOUT_FORM, new AboutForm());
            Application.Run(Forms[FormName.SPLASH_SCREEN]);
        }
    }
}
