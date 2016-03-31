// ***********************************************************************
// Assembly         : WinApp
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 02-05-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 02-17-2016
// ***********************************************************************
// <copyright file="Welcome.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Clase usada para el despliegue</summary>
// ***********************************************************************

namespace WinApp
{
    using Acnur.App.Aplication.Enumerators;
    using Acnur.App.Entities;
    using Acnur.App.Proxy;
    using DevExpress.XtraEditors;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class ACNUR.
    /// </summary>
    public partial class FormWelcome : XtraForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormWelcome"/> class.
        /// </summary>
        public FormWelcome()
        {
            InitializeComponent();
            this.LoadMenu();
        }

        /// <summary>
        /// Loads the menu.
        /// </summary>
        protected void LoadMenu()
        {
            using (CustomerModules client = new CustomerModules())
            {
                //// Obtiene la lista de modulos
                List<Modules> List = client.GetAll(false, null).ToList();

                //// Recorre la lista y adjunta la imagen que se va a mostrar al usuario
                List.ForEach(delegate(Modules mod)
                {
                    if (mod.ModuleName == TypeMenu.Purchase.ToString())
                    {
                        mod.Picture = WinApp.Properties.Resources.MenuPurchase;
                    }
                    if (mod.ModuleName == TypeMenu.Administration.ToString())
                    {
                        mod.Picture = WinApp.Properties.Resources.MenuAdmin;
                    }
                });

                //// Despliega los datos
                this.GrcMenu.DataSource = List;
            }
        }

        /// <summary>
        /// Handles the Click event of the RiPictureMenu control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void RiPictureMenu_Click(object sender, EventArgs e)
        {
            //// Selecciono el administrador
            if (CrvMenu.FocusedRowHandle == 0)
            {
                //// Abre la aplicación del adminsitrador
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.FileName = @"C:\\Program Files (x86)\\ACNURWinApp\\WinAdministrator.exe";
                System.Diagnostics.Process.Start(startInfo).WaitForExit();
            }

            //// Selecciono el purchase
            if (CrvMenu.FocusedRowHandle == 1)
            {
                //// Instanciamos el form request
                FormRequest request = new FormRequest();

                //// Lo abirmos en forma de dialogo
                request.ShowDialog();
            }
        }
    }
}