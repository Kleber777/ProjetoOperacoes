using ProjetoOperacoes.EntityFramework;
using ProjetoOperacoes.Models.ApplicationsModels;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoOperacoes.Repositories
{
    public class AccomplishedApplicationModelRepository
    {
        public List<AccomplishedApplicationModel> AccomplishedApplicationsList(string idAccountType)
        {
            List<AccomplishedApplicationModel> lstAccomplishedApplication = new List<AccomplishedApplicationModel>();
            List<ApplicationModel> lstApplication = new List<ApplicationModel>();

            using (var db = new ApplicationDBContext())
                lstApplication = db.ApplicationDbSet.ToList().FindAll(act => act.IdAccountType == idAccountType);

            foreach (var item in lstApplication)
                if (item.TypeApplication == ETypeApplication.ACCOMPLISHED)
                    lstAccomplishedApplication.Add(new AccomplishedApplicationModel());
            
            return lstAccomplishedApplication;
        }

    }
}
