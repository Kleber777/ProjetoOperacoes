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
        public static List<AccountTypeInputModel> ReadAccountTypeList(string idAccount)
        {
            List<AccountTypeInputModel> lstAccountTypeInputModel = new List<AccountTypeInputModel>();
            List<AccountTypeModel> lstAccountType = new List<AccountTypeModel>();

            lstAccountType = accountTypeRepository.ReadAccountTypeList(idAccount);
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

        public static void UpdateBalanceAccountType(AccountTypeInputModel accountTypeInputModel ,double newBalance)
        {
            AccountTypeModel accountTypeModel = new AccountTypeModel();
            
            accountTypeModel = accountTypeRepository.LoadById(accountTypeInputModel.ID);

            accountTypeModel.UpdateAccounTypeModel(accountTypeModel.ID,
                                                   accountTypeModel.IdBank,
                                                   accountTypeModel.NameAccountType,
                                                   accountTypeModel.AccountType,
                                                   newBalance);

            accountTypeRepository.UpdateAccountType(accountTypeModel);
        }
    }
}
