﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Acnur.App.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ACNUREntities : DbContext
    {
    	/// <summary>
    	/// Constructor ACNUREntities
    	/// </summary>
        public ACNUREntities()
            : base("name=ACNUREntities")
        {
    		this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
    		this.Configuration.AutoDetectChangesEnabled = false;
        }
    
    	/// <summary>
        /// Metodo para contruir el modelo
        /// </summary>
        /// <param name="modelBuilder">Objeto contructor del modelo</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    	/// <summary>
        /// Atributo GeneralInformationAction
        /// </summary>
        public virtual DbSet<GeneralInformationAction> GeneralInformationAction { get; set; }
    
    	/// <summary>
        /// Atributo GeneralInformationActionUsers
        /// </summary>
        public virtual DbSet<GeneralInformationActionUsers> GeneralInformationActionUsers { get; set; }
    
    	/// <summary>
        /// Atributo Audit
        /// </summary>
        public virtual DbSet<Audit> Audit { get; set; }
    
    	/// <summary>
        /// Atributo ComponentsByModule
        /// </summary>
        public virtual DbSet<ComponentsByModule> ComponentsByModule { get; set; }
    
    	/// <summary>
        /// Atributo Modules
        /// </summary>
        public virtual DbSet<Modules> Modules { get; set; }
    
    	/// <summary>
        /// Atributo ModuleUser
        /// </summary>
        public virtual DbSet<ModuleUser> ModuleUser { get; set; }
    
    	/// <summary>
        /// Atributo Operations
        /// </summary>
        public virtual DbSet<Operations> Operations { get; set; }
    
    	/// <summary>
        /// Atributo OperationsModule
        /// </summary>
        public virtual DbSet<OperationsModule> OperationsModule { get; set; }
    
    	/// <summary>
        /// Atributo OperationsModuleUser
        /// </summary>
        public virtual DbSet<OperationsModuleUser> OperationsModuleUser { get; set; }
    
    	/// <summary>
        /// Atributo Parameter
        /// </summary>
        public virtual DbSet<Parameter> Parameter { get; set; }
    
    	/// <summary>
        /// Atributo ParameterDetail
        /// </summary>
        public virtual DbSet<ParameterDetail> ParameterDetail { get; set; }
    
    	/// <summary>
        /// Atributo StepsFlow
        /// </summary>
        public virtual DbSet<StepsFlow> StepsFlow { get; set; }
    
    	/// <summary>
        /// Atributo StepsFlowModule
        /// </summary>
        public virtual DbSet<StepsFlowModule> StepsFlowModule { get; set; }
    
    	/// <summary>
        /// Atributo StepsFlowModuleUser
        /// </summary>
        public virtual DbSet<StepsFlowModuleUser> StepsFlowModuleUser { get; set; }
    
    	/// <summary>
        /// Atributo Users
        /// </summary>
        public virtual DbSet<Users> Users { get; set; }
    
    	/// <summary>
        /// Atributo CostApproval
        /// </summary>
        public virtual DbSet<CostApproval> CostApproval { get; set; }
    
    	/// <summary>
        /// Atributo ItineraryInformation
        /// </summary>
        public virtual DbSet<ItineraryInformation> ItineraryInformation { get; set; }
    
    	/// <summary>
        /// Atributo PT8
        /// </summary>
        public virtual DbSet<PT8> PT8 { get; set; }
    
    	/// <summary>
        /// Atributo SatffInformation
        /// </summary>
        public virtual DbSet<SatffInformation> SatffInformation { get; set; }
    
    	/// <summary>
        /// Atributo GeneralInformationEmergency
        /// </summary>
        public virtual DbSet<GeneralInformationEmergency> GeneralInformationEmergency { get; set; }
    
    	/// <summary>
        /// Atributo GeneralInformationEmergencyUsers
        /// </summary>
        public virtual DbSet<GeneralInformationEmergencyUsers> GeneralInformationEmergencyUsers { get; set; }
    
    	/// <summary>
        /// Atributo GeneralInformationEvent
        /// </summary>
        public virtual DbSet<GeneralInformationEvent> GeneralInformationEvent { get; set; }
    
    	/// <summary>
        /// Atributo GeneralInformationEventUsers
        /// </summary>
        public virtual DbSet<GeneralInformationEventUsers> GeneralInformationEventUsers { get; set; }
    
    	/// <summary>
        /// Atributo PressData
        /// </summary>
        public virtual DbSet<PressData> PressData { get; set; }
    
    	/// <summary>
        /// Atributo AnnexC
        /// </summary>
        public virtual DbSet<AnnexC> AnnexC { get; set; }
    
    	/// <summary>
        /// Atributo DataProject
        /// </summary>
        public virtual DbSet<DataProject> DataProject { get; set; }
    
    	/// <summary>
        /// Atributo DescriptionOfTheTargetPopulation
        /// </summary>
        public virtual DbSet<DescriptionOfTheTargetPopulation> DescriptionOfTheTargetPopulation { get; set; }
    
    	/// <summary>
        /// Atributo NationalPriorities
        /// </summary>
        public virtual DbSet<NationalPriorities> NationalPriorities { get; set; }
    
    	/// <summary>
        /// Atributo Weekly
        /// </summary>
        public virtual DbSet<Weekly> Weekly { get; set; }
    
    	/// <summary>
        /// Atributo WeeklyRequest
        /// </summary>
        public virtual DbSet<WeeklyRequest> WeeklyRequest { get; set; }
    
    	/// <summary>
        /// Atributo Events
        /// </summary>
        public virtual DbSet<Events> Events { get; set; }
    
    	/// <summary>
        /// Atributo Goods
        /// </summary>
        public virtual DbSet<Goods> Goods { get; set; }
    
    	/// <summary>
        /// Atributo Request
        /// </summary>
        public virtual DbSet<Request> Request { get; set; }
    
    	/// <summary>
        /// Atributo Services
        /// </summary>
        public virtual DbSet<Services> Services { get; set; }
    
    	/// <summary>
        /// Atributo GeneralInformationRiskProfile
        /// </summary>
        public virtual DbSet<GeneralInformationRiskProfile> GeneralInformationRiskProfile { get; set; }
    
    	/// <summary>
        /// Atributo GeneralInformationRiskProfileUsers
        /// </summary>
        public virtual DbSet<GeneralInformationRiskProfileUsers> GeneralInformationRiskProfileUsers { get; set; }
    
    	/// <summary>
        /// Atributo ParameterUserProcessed
        /// </summary>
        public virtual DbSet<ParameterUserProcessed> ParameterUserProcessed { get; set; }
    
    	/// <summary>
        /// Atributo SessionComponentsByModule
        /// </summary>
        public virtual DbSet<SessionComponentsByModule> SessionComponentsByModule { get; set; }
    
    	/// <summary>
        /// Atributo Sessions
        /// </summary>
        public virtual DbSet<Sessions> Sessions { get; set; }
    
    	/// <summary>
        /// Atributo SessionTargetMailProcessed
        /// </summary>
        public virtual DbSet<SessionTargetMailProcessed> SessionTargetMailProcessed { get; set; }
    
    	/// <summary>
        /// Atributo SessionTargetMails
        /// </summary>
        public virtual DbSet<SessionTargetMails> SessionTargetMails { get; set; }
    
    	/// <summary>
        /// Atributo Attachments
        /// </summary>
        public virtual DbSet<Attachments> Attachments { get; set; }
    
    }
}