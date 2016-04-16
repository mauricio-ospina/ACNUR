// ***********************************************************************
// Assembly         : Acnur.App.Proxy
// Author           : MAURO-DEFENSORIA
// Created          : 04-16-2016
//
// Last Modified By : MAURO-DEFENSORIA
// Last Modified On : 04-16-2016
// ***********************************************************************
// <copyright file="CustomerAttachments.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Acnur.App.Proxy
{
    using Acnur.App.Entities;
    using Acnur.App.Interfaces;

    /// <summary>
    /// Class CustomerAttachments.
    /// </summary>
    /// <seealso cref="Acnur.App.Proxy.CustomerGenericFacade{Acnur.App.Interfaces.IFacadeAttachments,Acnur.App.Entities.Attachments}" />
    /// <seealso cref="Acnur.App.Interfaces.IFacadeAttachments" />
    public class CustomerAttachments : CustomerGenericFacade<IFacadeAttachments, Attachments>, IFacadeAttachments
    {
    }
}
