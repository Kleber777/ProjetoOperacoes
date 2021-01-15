using ProjetoOperacoes.EntityFramework;
using ProjetoOperacoes.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoOperacoes.Repositories
{
    public class AccountModelRepository
    {
        public List<AccountModel> AccountsList()
        {
            List<AccountModel> lstContas = new List<AccountModel>();

            using (var db = new ApplicationDBContext())
                lstContas = db.AccountsDbSet.ToList();

            return lstContas;
        }

        public void InsertAccount(AccountModel obj)
        {
            try
            {
                using (var db = new ApplicationDBContext())
                {
                    db.AccountsDbSet.Add(obj);
                    db.SaveChanges();
                }

            }
            catch (System.Exception)
            {

                throw;
            }
        }


    }
}
