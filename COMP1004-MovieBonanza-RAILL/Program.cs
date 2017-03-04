using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_MovieBonanza_RAILL
{
   public static class Program
    {
        //declared globally 
        public static splashScreen MySplashScreen;

        //declared public static form
        public static SelectionForm MySelectionForm;
         /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            //initialize splashScreen and selectionForm
            Program.MySplashScreen = new splashScreen();
            Program.MySelectionForm = new SelectionForm();

            Application.Run(Program.MySplashScreen);
        }
    }
}
