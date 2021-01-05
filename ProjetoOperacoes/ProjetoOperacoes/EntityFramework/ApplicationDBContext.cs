using ProjetoOperacoes.Models;
using System.Data.Entity;

namespace ProjetoOperacoes.EntityFramework
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() : base("CnDatabase")
        {
        }

        public DbSet<AccountModel> AccountsDbSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.HasDefaultSchema("public");
            base.OnModelCreating(builder);
        }
    }
}
