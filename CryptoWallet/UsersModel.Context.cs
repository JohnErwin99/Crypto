//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CryptoWallet
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UsersEntities : DbContext
    {
        public UsersEntities()
            : base("name=UsersEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CryptoInformation> CryptoInformations { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<BankingInformation> BankingInformations { get; set; }
    }
}
