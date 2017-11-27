using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AumaticScreenSaver
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (args.Length > 0)
            {
                string firstArgument = args[0].ToLower().Trim();
                string secondArgument = null;

                if (firstArgument.Length > 2)
                {
                    secondArgument = firstArgument.Substring(3).Trim();
                    firstArgument = firstArgument.Substring(0, 2);
                }
                else if (args.Length > 1)
                    secondArgument = args[1];

                if (firstArgument == "/c")           // Configuration mode
                {
                    ShowSettingWindow();
                    Application.Run();
                }
                else if (firstArgument == "/p")      // Preview mode
                {
                    ShowScreenSaver();
                    ShowTranScreen();
                    Application.Run();
                }
                else if (firstArgument == "/s")      // Full-screen mode
                {
                    ShowScreenSaver();
                    ShowTranScreen();
                    Application.Run();
                }
            }
        }
        static void ShowScreenSaver() 
        {
            foreach (Screen screen in Screen.AllScreens)
            {
                ScreenSaverForm screensaver = new ScreenSaverForm(screen.Bounds);//Tworzy obiekt clasy ScreenSaverForm
                screensaver.Show();//Pokazuje obiekt
            }
        }
        static void ShowTranScreen()
        {
            foreach (Screen screen in Screen.AllScreens)
            {
                TransparentyForm line = new TransparentyForm(screen.Bounds);//Tworzy obiekt clasy TransparentyForm
                line.Show();//Pokazuje obiekt
            }
        }
        static void ShowSettingWindow()
        {
            Setting window = new Setting();//Tworzy obiekt clasy Setting
            window.Show();//Pokazuje obiekt
        }
    }
}
