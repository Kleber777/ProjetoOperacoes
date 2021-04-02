using ProjetoOperacoes.EntityFramework;
using ProjetoOperacoes.Models.ApplicationsModels;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoOperacoes.Repositories
{
    public class FutureApplicationModelRepository
    {
        public List<FutureApplicationModel> FutureApplicationsList(string idAccountType)
        {
            List<FutureApplicationModel> lstFutureApplication = new List<FutureApplicationModel>();
            List<TbApplication> lstApplication = new List<TbApplication>();

            using (var db = new ApplicationDBContext())
                lstApplication = db.ApplicationDbSet.ToList().FindAll(act => act.IdAccountType == idAccountType);

            foreach (var item in lstApplication)
                if (item.TypeApplication == ETypeApplication.FUTURE)
                    lstFutureApplication.Add(new FutureApplicationModel(item.IdAccountType, item.Description
                        , item.HasInstallments, item.PaidInstallments, item.Installments, item.IndividualValue, item.TypeApplication));

            return lstFutureApplication;
        }

    }
}
