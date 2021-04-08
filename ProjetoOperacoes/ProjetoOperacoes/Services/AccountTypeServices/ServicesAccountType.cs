using ProjetoOperacoes.InputModels;
using ProjetoOperacoes.Models.AccountTypeModels;
using ProjetoOperacoes.Repositories;
using System.Collections.Generic;

namespace ProjetoOperacoes.Services.AccountTypeServices
{
    public static class ServicesAccountType
    {
        private static readonly AccountTypeModelRepository accountTypeRepository = new AccountTypeModelRepository();

        //AccountTypeRepository
        public static List<AccountTypeInputModel> AccountsTypeListByIdAccount(string idAccount)
        {
            List<AccountTypeInputModel> lstAccountTypeInputModel = new List<AccountTypeInputModel>();
            List<AccountTypeModel> lstAccountType = new List<AccountTypeModel>();

            lstAccountType = accountTypeRepository.AccountTypesList(idAccount);
            foreach (var item in lstAccountType)
            {
                lstAccountTypeInputModel.Add(new AccountTypeInputModel(item.ID,
                                                                       item.IdBank,
                                                                       item.NameAccountType,
                                                                       item.AccountType,
                                                                       //null, 
                                                                       //null, 
                                                                       //null, 
                                                                       //null,
                                                                       item.Balance));
            }

            return lstAccountTypeInputModel;
        }

    }
}
