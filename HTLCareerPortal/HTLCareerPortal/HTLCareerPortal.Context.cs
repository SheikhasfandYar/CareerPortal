﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HTLCareerPortal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HTLCareerEntities : DbContext
    {
        public HTLCareerEntities()
            : base("name=HTLCareerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<citySetup> citySetups { get; set; }
        public virtual DbSet<jobApplying> jobApplyings { get; set; }
        public virtual DbSet<JobSetup> JobSetups { get; set; }
        public virtual DbSet<tbl_CareerObjective> tbl_CareerObjective { get; set; }
        public virtual DbSet<tbl_Department> tbl_Department { get; set; }
        public virtual DbSet<tbl_Experience> tbl_Experience { get; set; }
        public virtual DbSet<tbl_FOI> tbl_FOI { get; set; }
        public virtual DbSet<tbl_GeneralInfo> tbl_GeneralInfo { get; set; }
        public virtual DbSet<tbl_Images> tbl_Images { get; set; }
        public virtual DbSet<tbl_PersonalInfo> tbl_PersonalInfo { get; set; }
        public virtual DbSet<tbl_ProfessionalReference> tbl_ProfessionalReference { get; set; }
        public virtual DbSet<tbl_Resumes> tbl_Resumes { get; set; }
        public virtual DbSet<tbl_Education> tbl_Education { get; set; }
        public virtual DbSet<tbl_JobSalaryPreference> tbl_JobSalaryPreference { get; set; }
        public virtual DbSet<tbl_AdminToHod> tbl_AdminToHod { get; set; }
        public virtual DbSet<tbl_SignUp> tbl_SignUp { get; set; }
    }
}
