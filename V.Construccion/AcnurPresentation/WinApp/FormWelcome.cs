// ***********************************************************************
// Assembly         : WinApp
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 02-05-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 04-23-2016
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
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using WinApp.Properties;
    using Outlook = Microsoft.Office.Interop.Outlook;

    /// <summary>
    /// Class FormWelcome.
    /// </summary>
    /// <seealso cref="DevExpress.XtraEditors.XtraForm" />
    public partial class FormWelcome : XtraForm
    {
        /// <summary>
        /// Sets the data purchase.
        /// </summary>
        /// <value>The data purchase.</value>
        public string DataPurchase
        {
            get { return this.MemoDataPurchase.Text; }
            set { this.MemoDataPurchase.Text = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormWelcome"/> class.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public FormWelcome(string[] args)
        {
            InitializeComponent();

            ////===================================================================
            //// Instrucción permite realizar la prueba sin la conexión al AddIns 
            //// se debe retirar en el ambiente de producción
            ////===================================================================
            //// 
            ////if (args.Length == 0 || null == args[0])
            ////{
            ////    Program.CurrentUser = "chospina";
            ////    Program.CurrentUserName = "Christian Mauricio Ospina Gomez";
            ////    Program.CurrentId = "00000000DCA740C8C042101AB4B908002B2FE18201000000000000002F6F3D45786368616E67654C6162732F6F753D45786368616E67652041646D696E6973747261746976652047726F7570202846594449424F484632335350444C54292F636E3D526563697069656E74732F636E3D64306230643564663232366634383337613166343565386464313066393936322D4368697269737469616E00";
            ////}
            ////===================================================================

            if (string.IsNullOrEmpty(Program.CurrentUser) || null == Program.CurrentUser)
                if (args.Length > 0)
                {
                    Program.CurrentUser = args[0];
                    Program.CurrentUserName = args[1].ToString().Replace('_', ' ') + " " + args[2].ToString().Replace('_', ' ');
                    Program.CurrentId = args[3];
                    Program.CurrentRequest = args[4];
                }

            this.LoadMenu(args);
        }

        /// <summary>
        /// Loads the menu.
        /// </summary>
        /// <param name="args">The arguments.</param>
        protected void LoadMenu(string[] args)
        {
            //// Instanciamos la lista a usar
            List<Modules> List = new List<Modules>();

            //// Conexión con el próxy
            using (CustomerModules client = new CustomerModules())
            {
                //// Obtiene la lista de modulos
                List = client.GetModulesByUser(Program.CurrentUser);
            }

            if (List.Count > 0)
            {
                //// Recorre la lista y adjunta la imagen que se va a mostrar al usuario
                List.ForEach(delegate(Modules mod)
                {
                    if (mod.ModuleName == TypeMenu.Purchase.ToString())
                    {
                        mod.Picture = Resources.MenuPurchase;
                    }
                    if (mod.ModuleName == TypeMenu.Administration.ToString())
                    {
                        mod.Picture = Resources.MenuAdmin;
                    }
                });

                //// Despliega los datos
                this.GrcMenu.DataSource = List;
            }

            else
            {
                XtraMessageBox.Show("You do not have privileges to enter. Please consult administrator");
                this.BtnFinalize.Visible = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the RiPictureMenu control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void RiPictureMenu_Click(object sender, EventArgs e)
        {
            string Menu = CrvMenu.GetRowCellValue(CrvMenu.FocusedRowHandle, ColName).ToString();
            TypeMenu MenuType = (TypeMenu)Enum.Parse(typeof(TypeMenu), Menu);

            switch (MenuType)
            {
                case TypeMenu.Administration:
                    //// Abre la aplicación del administrador
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.FileName = @"C:\\Program Files (x86)\\ACNURWinApp\\WinAdministrator.exe";
                    System.Diagnostics.Process.Start(startInfo).WaitForExit();
                    break;

                case TypeMenu.Purchase:
                    //// Instanciamos el form request
                    FormRequest request = new FormRequest();
                    request.ShowDialog();
                    this.DataPurchase = request.LoadBodyPurchase();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// BTNs the finalize_ click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void BtnFinalize_Click(object sender, EventArgs e)
        {
            if (this.ValidateInformationForSend())
            {
                try
                {
                    Outlook.Application outlookApp = null;

                    if (Process.GetProcessesByName("OUTLOOK").Count() > 0)
                    {
                        //// Si encuentra que la aplicación de outlook ya esta abierta
                        outlookApp = Marshal.GetActiveObject("Outlook.Application") as Outlook.Application;
                    }
                    else
                    {
                        // If not, create a new instance of Outlook and log on to the default profile. 
                        outlookApp = new Outlook.Application();
                        Outlook.NameSpace nameSpace = outlookApp.GetNamespace("MAPI");
                        nameSpace.Logon("", "", Missing.Value, Missing.Value);
                        nameSpace = null; 
                    }

                    //// Crea el item
                    Outlook._MailItem oMailItem = (Outlook._MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);

                    //// Valida si viene de algún correo
                    if (Program.CurrentId != "StrIds_null")
                    {
                        oMailItem = outlookApp.GetNamespace("MAPI").GetItemFromID(Program.CurrentId) as Outlook.MailItem;
                    }
                    
                    //// Adiciona lo que se quiere enviar Id´s
                    oMailItem.BillingInformation = "BILLING INFORMATION - 5,6,7 (goods)";

                    //// Adiciona el Subject
                    oMailItem.Subject = "Test Mail";

                    //// En el instalador debe ir la carpeta TEMPLATES y finalemente la plantilla de HTML.
                    string estiloCorreo = File.ReadAllText("C:\\Program Files (x86)\\ACNURWinApp\\Correo.html");

                    //// Reemplace el titulo y el contenido en la plantilla
                    estiloCorreo = estiloCorreo.Replace("{TITULO}", "PURCHASE");
                    estiloCorreo = estiloCorreo.Replace("{CONTENIDO}", this.DataPurchase);

                    //// Coloca el string en el cuerpo del correo
                    oMailItem.HTMLBody = estiloCorreo;

                    //// Muestra mailbox
                    oMailItem.Display(true);

                    //// Cierra la aplicación
                    this.Close();
                    Program.CloseApplication();
                }
                catch (Exception objEx)
                {
                    throw objEx;
                }
            }
        }

        /// <summary>
        /// Validates the information for send.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool ValidateInformationForSend()
        {
            bool valid = false;

            if (string.IsNullOrEmpty(this.DataPurchase))
                XtraMessageBox.Show("No information to be sent");
            else
                valid = true;

            return valid;
        }
    }
}