//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CvEntityProje
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCvEntities : DbContext
    {
        public DbCvEntities()
            : base("name=DbCvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Mesajlar> Mesajlar { get; set; }
        public virtual DbSet<Bilgiler> Bilgiler { get; set; }
        public virtual DbSet<Calismalar> Calismalar { get; set; }
        public virtual DbSet<GenelBilgiler> GenelBilgiler { get; set; }
        public virtual DbSet<Yetenekler> Yetenekler { get; set; }
        public virtual DbSet<Adminler> Adminler { get; set; }
    }
}
