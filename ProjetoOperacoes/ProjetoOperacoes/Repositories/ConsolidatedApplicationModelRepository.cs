﻿using ProjetoOperacoes.EntityFramework;
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
            List<ApplicationModel> lstApplication = new List<ApplicationModel>();

            using (var db = new ApplicationDBContext())
                lstApplication = db.ApplicationDbSet.ToList().FindAll(act => act.IdAccountType == idAccountType);

            foreach (var item in lstApplication)
                if (item.TypeApplication == ETypeApplication.CONSOLIDATED)
                    lstConsolidatedApplication.Add(new ConsolidatedApplicationModel());

            return lstConsolidatedApplication;
        }

    }
}
