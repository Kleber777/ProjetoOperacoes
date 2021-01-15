using ProjetoOperacoes.EntityFramework;
using ProjetoOperacoes.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoOperacoes.Repositories
{
    public class ConsolidatedApplicationModelRepository
    {
        public List<ConsolidatedApplicationModel> ConsolidateApplicationsList(string idAccountType)
        {
            List<ConsolidatedApplicationModel> lstConsolidatedApplication = new List<ConsolidatedApplicationModel>();

            using (var db = new ApplicationDBContext())
                lstConsolidatedApplication = db.ConsolidateApplicationDbSet.ToList().FindAll(act => act.IdAccountTypes == idAccountType);

            return lstConsolidatedApplication;
        }

    }
}
