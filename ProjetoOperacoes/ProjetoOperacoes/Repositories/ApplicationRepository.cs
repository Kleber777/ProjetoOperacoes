using ProjetoOperacoes.EntityFramework;
using ProjetoOperacoes.Models.ApplicationsModels;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoOperacoes.Repositories
{
    public class ApplicationRepository
    {
        public List<ApplicationModel> ApplicationList(string idAccountType)
        {
            List<ApplicationModel> lstApplication = new List<ApplicationModel>();

            using (var db = new ApplicationDBContext())
                lstApplication = db.ApplicationDbSet.ToList().FindAll(act => act.IdAccountType == idAccountType);

            return lstApplication;
        }

        public void InsertApplication(ApplicationModel obj)
        {

            try
            {
                using (var db = new ApplicationDBContext())
                {
                    db.ApplicationDbSet.Add(obj);
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
