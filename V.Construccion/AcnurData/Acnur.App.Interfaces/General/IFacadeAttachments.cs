// ***********************************************************************
// Assembly         : Acnur.App.Interfaces
// Author           : MAURO-DEFENSORIA
// Created          : 04-16-2016
//
// Last Modified By : MAURO-DEFENSORIA
// Last Modified On : 04-16-2016
// ***********************************************************************
// <copyright file="IFacadeAttachments.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Acnur.App.Interfaces
{
    using Acnur.App.Entities;
    using System.ServiceModel;

    /// <summary>
    /// Interface IFacadeAttachments
    /// </summary>
    /// <seealso cref="Acnur.App.Interfaces.IFacadeGeneric{Acnur.App.Entities.Attachments}" />
    [ServiceContract]
    public interface IFacadeAttachments : IFacadeGeneric<Attachments>
    {
    }
}
