using ProjetoOperacoes.EntityFramework;
using ProjetoOperacoes.Models.ApplicationsModels;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoOperacoes.Repositories
{
    public class TbApplicationRepository
    {
        public List<TbApplication> TbApplicationsList(string idAccountType)
        {
            List<TbApplication> lstApplication = new List<TbApplication>();

            using (var db = new ApplicationDBContext())
                lstApplication = db.ApplicationDbSet.ToList().FindAll(act => act.IdAccountType == idAccountType);

            return lstApplication;
        }

        public void InsertApplication(ApplicationModel obj)
        {

            var teste = (TbApplication)obj;
            try
            {
                using (var db = new ApplicationDBContext())
                {
                    db.ApplicationDbSet.Add(teste);
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
