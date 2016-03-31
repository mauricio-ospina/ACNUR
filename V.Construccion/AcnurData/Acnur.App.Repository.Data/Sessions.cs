//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Acnur.App.Repository.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sessions
    {
        public Sessions()
        {
            this.SessionComponentsByModule = new HashSet<SessionComponentsByModule>();
            this.SessionTargetMails = new HashSet<SessionTargetMails>();
        }
    
        public int IdSession { get; set; }
        public string GUID { get; set; }
        public string SourceEmail { get; set; }
        public string Subject { get; set; }
        public string BodyMail { get; set; }
        public bool Send { get; set; }
        public int IdProcessGroup { get; set; }
    
        public virtual ParameterDetail ParameterDetail { get; set; }
        public virtual ICollection<SessionComponentsByModule> SessionComponentsByModule { get; set; }
        public virtual ICollection<SessionTargetMails> SessionTargetMails { get; set; }
    }
}