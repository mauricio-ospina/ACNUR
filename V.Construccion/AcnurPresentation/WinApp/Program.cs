﻿// ***********************************************************************
// Assembly         : WinApp
// Author           : MAURO-DEFENSORIA
// Created          : 03-22-2016
//
// Last Modified By : MAURO-DEFENSORIA
// Last Modified On : 04-23-2016
// ***********************************************************************
// <copyright file="Program.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace WinApp
{
    using DevExpress.LookAndFeel;
    using System;
    using System.Diagnostics;
    using System.Windows.Forms;

    /// <summary>
    /// Class Program.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The current user
        /// </summary>
        public static string CurrentUser;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ////=============================================================================
            //// Utilizado para validar los parámetros que estan saliendo y llegando
            ////=============================================================================
            //// MessageBox.Show("se han pasado " + args.Length.ToString() + " argumentos");
            //// string str = string.Empty;
            //// args.ToList().ForEach(item => str += item + ", ");
            //// MessageBox.Show("se ha pasado el argumento: " + str);
            ////==============================================================================

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            
            if (!IsExecutingApplication())
            {
                Application.Run(new FormWelcome(args));
            }
        }

        /// <summary>
        /// Determines whether [is executing application].
        /// </summary>
        /// <returns><c>true</c> if [is executing application]; otherwise, <c>false</c>.</returns>
        private static bool IsExecutingApplication()
        {
            //// Proceso actual
            Process currentProcess = Process.GetCurrentProcess();

            //// Matriz de procesos
            Process[] processes = Process.GetProcesses();

            //// Recorremos los procesos en ejecución
            foreach (Process p in processes)
            {
                if (p.Id != currentProcess.Id)
                {
                    if (p.ProcessName == currentProcess.ProcessName)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}