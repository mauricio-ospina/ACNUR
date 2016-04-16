namespace WinApp
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using DevExpress.LookAndFeel;
    using System.Linq;
    using Outlook = Microsoft.Office.Interop.Outlook;

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

            MessageBox.Show("se han pasado " + args.Length.ToString() + " argumentos");

            string str = string.Empty;
            args.ToList().ForEach(item => str += item + ", ");
            MessageBox.Show("se ha pasado el argumento: " + str);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            Application.Run(new FormWelcome(args));
        }
    }
}