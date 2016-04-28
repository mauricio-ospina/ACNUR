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
            if (args.Length == 0 || null == args[0])
            //// 
            Program.CurrentUser = "MOSPINA";
            ////===================================================================

            if (string.IsNullOrEmpty(Program.CurrentUser) || null == Program.CurrentUser)
                if (args.Length > 0)
                    Program.CurrentUser = args[0];

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
                request.ShowDialog();
                this.DataPurchase = request.LoadBodyPurchase();
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
                    //// A continuación se muestra codificada - pueden ser reemplazados con los datos db
                    //// List<string> lstAllRecipients = new List<string>();
                    //// lstAllRecipients.Add("ambrosio.mauro@gmail.com");
                    //// lstAllRecipients.Add("chospina@defensoria.gov.co");

                    Outlook.Application outlookApp = null;

                    if (Process.GetProcessesByName("OUTLOOK").Count() > 0)
                    {
                        // If so, use the GetActiveObject method to obtain the process and cast it to an Application object.
                        outlookApp = Marshal.GetActiveObject("Outlook.Application") as Outlook.Application;
                    }
                    else { outlookApp = new Outlook.Application(); }

                    Outlook._MailItem oMailItem = (Outlook._MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
                    Outlook.Inspector oInspector = oMailItem.GetInspector;

                    //// Recipient
                    //// Outlook.Recipients oRecips = (Outlook.Recipients)oMailItem.Recipients;
                    //// foreach (String recipient in lstAllRecipients)
                    //// {
                    ////    Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add(recipient);
                    ////    oRecip.Resolve();
                    //// }

                    //// Add CC
                    //// Outlook.Recipient oCCRecip = oRecips.Add("mauricio_ospina_6@hotmail.com");
                    //// oCCRecip.Type = (int)Outlook.OlMailRecipientType.olCC;
                    //// oCCRecip.Resolve();

                    //// Add Subject

                    //// oMailItem.ConversationID ---- VALIDAR SI ESTA VARIABLE GUARDA EL ID DE LA CONVERSACION EN EL HISTORIAL DE CORREOS 
                    oMailItem.Categories = "CATEGORIES - estos son los ID´s que se pueden enviar por aca";
                    oMailItem.BillingInformation = "BILLING INFORMATION - estos son los ID´s que se pueden enviar por aca";
                    oMailItem.Subject = "Test Mail";

                    //// Utilizado para las pruebas locales
                    //// string estiloCorreo = File.ReadAllText("C:\\Users\\MAURO-DEFENSORIA\\Documents\\Chospina\\Acnur\\trunk\\V.Construccion\\AcnurPresentation\\WinApp\\Templates\\Correo.html");

                    //// En el instalador debe ir la carpeta TEMPLATES y finalemente la plantilla de HTML.
                    string estiloCorreo = File.ReadAllText("C:\\Program Files (x86)\\ACNURWinApp\\Correo.html");

                    //// Para que se ejecute el javascript toca que sea desde un browser. El inconveniente es que 
                    //// es una violación de seguridad ejecutar un .exe desde un browser. Desde IExplore funciona
                    //// desde chrome no. Debe ser configuración en la seguridad del navegador. Se recomienda buscar
                    //// una solución diferente.
                    //// string strBody = "<a href='javascript:runProgram()'>Run program</a>";

                    //// Reemplace el titulo y el contenido en la plantilla
                    estiloCorreo = estiloCorreo.Replace("{TITULO}", "PURCHASE");
                    estiloCorreo = estiloCorreo.Replace("{CONTENIDO}", this.DataPurchase);

                    //// Coloca el string en el cuerpo del correo
                    oMailItem.HTMLBody = estiloCorreo;

                    //// Display mailbox
                    oMailItem.Display(true);
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