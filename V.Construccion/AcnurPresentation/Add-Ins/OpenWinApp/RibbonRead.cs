// ***********************************************************************
// Assembly         : OpenWinApp
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 02-05-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 03-28-2016
// ***********************************************************************
// <copyright file="RibbonRead.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace OpenWinApp
{
    using Microsoft.Office.Tools.Ribbon;
    using System.Diagnostics;

    /// <summary>
    /// Class RibbonRead.
    /// </summary>
    /// <seealso cref="Microsoft.Office.Tools.Ribbon.RibbonBase" />
    public partial class RibbonRead
    {
        /// <summary>
        /// Handles the Click event of the BtnOpenApp control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RibbonControlEventArgs" /> instance containing the event data.</param>
        private void BtnOpenApp_Click(object sender, RibbonControlEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\\Program Files (x86)\\ACNURWinApp\\WinApp.exe";
            Process.Start(startInfo).WaitForExit();
        }
    }
}
