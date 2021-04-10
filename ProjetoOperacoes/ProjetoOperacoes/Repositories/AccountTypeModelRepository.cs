using ProjetoOperacoes.EntityFramework;
using ProjetoOperacoes.Models.AccountTypeModels;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Migrations;

namespace ProjetoOperacoes.Repositories
{
    public class AccountTypeModelRepository
    {

        public AccountTypeModel LoadById(string id)
        {
            try
            {
                AccountTypeModel accountType = new AccountTypeModel();

                using (var db = new ApplicationDBContext())
                    accountType = db.AccountsTypeDbSet.Find(id);

                return accountType;

            }
            catch (System.Exception)
            {

                throw;
            }

        }

        public List<AccountTypeModel> ReadAccountTypeList(string idBank)
        {
            List<AccountTypeModel> lstAccountTypes = new List<AccountTypeModel>();

            using (var db = new ApplicationDBContext())
                lstAccountTypes = db.AccountsTypeDbSet.ToList().FindAll(act => act.IdBank == idBank);

            return lstAccountTypes;
        }

        public void UpdateAccountType(AccountTypeModel obj)
        {
            try
            {
                using (var db = new ApplicationDBContext())
                {
                    db.AccountsTypeDbSet.AddOrUpdate(obj);
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
