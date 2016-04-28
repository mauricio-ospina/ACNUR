// ***********************************************************************
// Assembly         : Acnur.App.Implementation
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 04-16-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 04-23-2016
// ***********************************************************************
// <copyright file="FacadeAttachments.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Acnur.App.Implementation
{
    using Acnur.App.Entities;
    using Acnur.App.Interfaces;
    using Acnur.App.Repository;
    using System.Collections.Generic;

    /// <summary>
    /// Class FacadeAttachments.
    /// </summary>
    /// <seealso cref="Acnur.App.Implementation.FacadeGeneric{Acnur.App.Entities.Attachments}" />
    /// <seealso cref="Acnur.App.Interfaces.IFacadeAttachments" />
    public class FacadeAttachments : FacadeGeneric<Attachments>, IFacadeAttachments
    {
        /// <summary>
        /// Gets the attachments by identifier module.
        /// </summary>
        /// <param name="idModule">The identifier module.</param>
        /// <param name="idRegister">The identifier register.</param>
        /// <returns>List Attachments.</returns>
        public List<Attachments> GetAttachmentsByIdModule(int idModule, int idRegister)
        {
            List<Attachments> ResultList = new List<Attachments>();
            RepositoryData.Search<Attachments>(adj => adj.IdComponentByModule == idModule && adj.IdInformation == idRegister, false, null);
            return ResultList;
        }
    }
}
