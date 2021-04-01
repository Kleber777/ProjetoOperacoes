using ProjetoOperacoes.Models.AccountTypeModels;
using ProjetoOperacoes.Models.ApplicationsModels;
using ProjetoOperacoes.Models.BankModels;
using System.Data.Entity;

namespace ProjetoOperacoes.EntityFramework
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() : base("CnDatabase")
        {
            
        }
        public DbSet<BankModel> BanksDbSet { get; set; }
        public DbSet<AccountTypeModel> AccountsTypeDbSet { get; set; }
        public DbSet<ApplicationModel> ApplicationDbSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.HasDefaultSchema("public");
            base.OnModelCreating(builder);
        }
    }
}
