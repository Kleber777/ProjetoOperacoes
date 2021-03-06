﻿using ProjetoOperacoes.EntityFramework;
using ProjetoOperacoes.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoOperacoes.Repositories
{
    public class AccountTypeModelRepository
    {
        public List<AccountTypeModel> AccountTypesList(string idAccount)
        {
            List<AccountTypeModel> lstAccountTypes = new List<AccountTypeModel>();

            using (var db = new ApplicationDBContext())
                lstAccountTypes = db.AccountsTypeDbSet.ToList().FindAll(act => act.IdAccount == idAccount);

            return lstAccountTypes;
        }

    }
}
