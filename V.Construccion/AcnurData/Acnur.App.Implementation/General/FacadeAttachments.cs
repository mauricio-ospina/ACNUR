// ***********************************************************************
// Assembly         : Acnur.App.Implementation
// Author           : MAURO-DEFENSORIA
// Created          : 04-16-2016
//
// Last Modified By : MAURO-DEFENSORIA
// Last Modified On : 04-16-2016
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

    /// <summary>
    /// Class FacadeAttachments.
    /// </summary>
    /// <seealso cref="Acnur.App.Implementation.FacadeGeneric{Acnur.App.Entities.Attachments}" />
    /// <seealso cref="Acnur.App.Interfaces.IFacadeAttachments" />
    public class FacadeAttachments : FacadeGeneric<Attachments>, IFacadeAttachments
    {
    }
}
