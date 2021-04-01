using ProjetoOperacoes.EntityFramework;
using ProjetoOperacoes.Models.ApplicationsModels;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoOperacoes.Repositories
{
    public class ProgressApplicationModelRepository
    {
        public List<ProgressApplicationModel> ProgressApplicationsList(string idAccountType)
        {
            List<ProgressApplicationModel> lstProgressApplication = new List<ProgressApplicationModel>();
            List<ApplicationModel> lstApplication = new List<ApplicationModel>();

            using (var db = new ApplicationDBContext())
                lstApplication = db.ApplicationDbSet.ToList().FindAll(act => act.IdAccountType == idAccountType);

            foreach (var item in lstApplication)
                if (item.TypeApplication == ETypeApplication.PROGRESS)
                    lstProgressApplication.Add(new ProgressApplicationModel());

            return lstProgressApplication;
        }

    }
}
