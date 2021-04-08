using ProjetoOperacoes.InputModels;
using ProjetoOperacoes.Models.BankModels;
using ProjetoOperacoes.Repositories;
using System;
using System.Collections.Generic;

namespace ProjetoOperacoes.Services.BankServices
{
    public static class ServicesBank
    {
        //main
        private static readonly BankModelRepository bankRepository = new BankModelRepository();

        private static readonly AccountTypeModelRepository accountTypeRepository = new AccountTypeModelRepository();

        //BankRepository
        public static List<BankInputModel> BankList()
        {
            List<BankInputModel> lstContasInputModel = new List<BankInputModel>();
            List<BankModel> lstContas = new List<BankModel>();

            lstContas = bankRepository.BankList();

            foreach (var item in lstContas)
            {
                var teste = accountTypeRepository.AccountTypesList(item.ID);

                foreach (var iten in teste)
                    item.Amount += iten.Balance;

                lstContasInputModel.Add(new BankInputModel(item.ID, item.BankName, item.HexColor, item.IconPath, item.Amount));
            }

            return lstContasInputModel;
        }
        public static void InsertBank(BankInputModel obj)
        {
            var accountModel = new BankModel(obj.BankName, obj.HexColor, obj.Icon, Convert.ToDouble(obj.Amount));
            bankRepository.InsertBank(accountModel);
        }

    }
}
