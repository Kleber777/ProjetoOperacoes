using ProjetoOperacoes.EntityFramework;
using ProjetoOperacoes.Models.ApplicationsModels;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoOperacoes.Repositories
{
    public class ApplicationRepository
    {
        public ApplicationModel LoadById(string id)
        {
            try
            {
                ApplicationModel application = new ApplicationModel();

                using (var db = new ApplicationDBContext())
                    application = db.ApplicationDbSet.Find(id);

                return application;

            }
            catch (System.Exception)
            {

                throw;
            }

        }
        public void CreateApplication(ApplicationModel obj)
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
        public List<ApplicationModel> ReadApplicationList(string idAccountType)
        {
            List<ApplicationModel> lstApplication = new List<ApplicationModel>();

            using (var db = new ApplicationDBContext())
                lstApplication = db.ApplicationDbSet.ToList().FindAll(act => act.IdAccountType == idAccountType);

            return lstApplication;
        }
        public void UpdateApplication(ApplicationModel obj)
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
        public void DeleteApplication(ApplicationModel obj)
        {
            try
            {
                using (var db = new ApplicationDBContext())
                {
                    db.ApplicationDbSet.Attach(obj);
                    db.ApplicationDbSet.Remove(obj);
                    db.SaveChanges();
                }

            }
            catch (System.Exception ex)
            {
                throw ex;                
            }

        }

    }
}
