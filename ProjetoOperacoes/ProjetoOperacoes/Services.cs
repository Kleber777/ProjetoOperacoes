using ProjetoOperacoes.InputModel.AplicacaoConsolidadaInputModel;
using ProjetoOperacoes.InputModel.ContaInputModel;
using ProjetoOperacoes.InputModel.TiposContaInputModel;
using ProjetoOperacoes.Models;
using ProjetoOperacoes.Repositories;
using System;
using System.Collections.Generic;

namespace ProjetoOperacoes
{
    public class Services
    {
        private readonly AccountModelRepository accountRepository;
        private readonly AccountTypeModelRepository accountTypeRepository;
        private readonly ConsolidatedApplicationModelRepository consolidatedApplicationRepository;

        public Services()
        {
            accountRepository = new AccountModelRepository();
            accountTypeRepository = new AccountTypeModelRepository();
            consolidatedApplicationRepository = new ConsolidatedApplicationModelRepository();
        }

        //AccounRepository
        public List<ContaInputModel> AccountsList()
        {
            List<ContaInputModel> lstContasInputModel = new List<ContaInputModel>();
            List<AccountModel> lstContas = new List<AccountModel>();

            lstContas = accountRepository.AccountsList();
            foreach (var item in lstContas)
            {
                lstContasInputModel.Add(new ContaInputModel(item.Id, item.BankName, item.HexColor, item.IconPath, item.Amount));
            }

            return lstContasInputModel;
        }

        public void InsertAccount(ContaInputModel obj)
        {
            var accountModel = new AccountModel("", obj.NomeBanco, obj.CorHexadouble, obj.Icone, Convert.ToDouble(obj.ValorTotal));
            accountRepository.InsertAccount(accountModel);
        }

        //AccountTypeRepository
        public List<TiposContasInputModel> AccountsTypeListByIdAccount(string idAccount)
        {
            List<TiposContasInputModel> lstAccountTypeInputModel = new List<TiposContasInputModel>();
            List<AccountTypeModel> lstAccountType = new List<AccountTypeModel>();

            lstAccountType = accountTypeRepository.AccountTypesList(idAccount);
            foreach (var item in lstAccountType)
            {
                lstAccountTypeInputModel.Add(new TiposContasInputModel(item.Id,
                                                                       item.IdAccount,
                                                                       item.NameAccountType,
                                                                       item.AccountType,
                                                                       item.CountApplications,
                                                                       null, null, null, null, item.TotalAccountValue));
            }

            return lstAccountTypeInputModel;
        }

        //ConsolidateApplicationRepositoy
        public List<AplicacaoConsolidadaInputModel>  ConsolidateApplicationListByIdAccountType(string idAccountType)
        {

            List<AplicacaoConsolidadaInputModel> lstContasAplicacaoConsolidadaInputModel = new List<AplicacaoConsolidadaInputModel>();
            List<ConsolidatedApplicationModel> lstContasAplicacaoConsolidada = new List<ConsolidatedApplicationModel>();

            lstContasAplicacaoConsolidada = consolidatedApplicationRepository.ConsolidateApplicationsList(idAccountType);
            foreach (var item in lstContasAplicacaoConsolidada)
            {
                lstContasAplicacaoConsolidadaInputModel.Add(new AplicacaoConsolidadaInputModel(item.Id,
                                                                                               item.IdAccountTypes,
                                                                                               item.Description,
                                                                                               0,
                                                                                               item.IndividualValue,
                                                                                               item.TotalValue));
            }

            return lstContasAplicacaoConsolidadaInputModel;
        }
    }
}
