using ProjetoOperacoes.EntityFramework;
using ProjetoOperacoes.Models.BankModels;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoOperacoes.Repositories
{
    public class BankModelRepository
    {
        public List<BankModel> BankList()
        {
            List<BankModel> lstContas = new List<BankModel>();

            using (var db = new ApplicationDBContext())
                lstContas = db.BanksDbSet.ToList();

            return lstContas;
        }

        public void InsertBank(BankModel obj)
        {
            try
            {
                using (var db = new ApplicationDBContext())
                {
                    db.BanksDbSet.Add(obj);
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
