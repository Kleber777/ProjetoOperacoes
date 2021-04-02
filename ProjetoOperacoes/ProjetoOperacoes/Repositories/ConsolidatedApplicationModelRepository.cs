using ProjetoOperacoes.EntityFramework;
using ProjetoOperacoes.Models.ApplicationsModels;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoOperacoes.Repositories
{
    public class ConsolidatedApplicationModelRepository
    {
        public List<ConsolidatedApplicationModel> ConsolidateApplicationsList(string idAccountType)
        {
            List<ConsolidatedApplicationModel> lstConsolidatedApplication = new List<ConsolidatedApplicationModel>();
            List<TbApplication> lstApplication = new List<TbApplication>();

            using (var db = new ApplicationDBContext())
                lstApplication = db.ApplicationDbSet.ToList().FindAll(act => act.IdAccountType == idAccountType);

            foreach (var item in lstApplication)
                if (item.TypeApplication == ETypeApplication.CONSOLIDATED)
                    lstConsolidatedApplication.Add(new ConsolidatedApplicationModel(item.IdAccountType, item.Description
                        ,item.HasInstallments, item.PaidInstallments, item.Installments, item.IndividualValue, item.TypeApplication));

            return lstConsolidatedApplication;
        }

    }
}
