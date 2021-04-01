using ProjetoOperacoes.InputModel.AccountInputModel;
using ProjetoOperacoes.InputModel.AccountTypeInputModel;
using ProjetoOperacoes.InputModel.ConsolidateApplicationInputModel;
using ProjetoOperacoes.InputModel.FutureApplicationInputModel;
using ProjetoOperacoes.Models;
using ProjetoOperacoes.Repositories;
using System;
using System.Collections.Generic;

namespace ProjetoOperacoes
{
    public class Services
    {
        private readonly BankModelRepository accountRepository;
        private readonly AccountTypeModelRepository accountTypeRepository;
        private readonly ConsolidatedApplicationModelRepository consolidatedApplicationRepository;
        private readonly FutureApplicationModelRepository futureApplicationRepository;
        private readonly ProgressApplicationModelRepository progressApplicationRepository;
        private readonly AccomplishedApplicationModelRepository accomplishedApplicationRepository;

        public Services()
        {
            accountRepository = new BankModelRepository();
            accountTypeRepository = new AccountTypeModelRepository();
            consolidatedApplicationRepository = new ConsolidatedApplicationModelRepository();
            futureApplicationRepository = new FutureApplicationModelRepository();
            progressApplicationRepository = new ProgressApplicationModelRepository();
            accomplishedApplicationRepository = new AccomplishedApplicationModelRepository();
        }

        //AccounRepository
        public List<AccountInputModel> AccountsList()
        {
            List<AccountInputModel> lstContasInputModel = new List<AccountInputModel>();
            List<BankModel> lstContas = new List<BankModel>();

            lstContas = accountRepository.BankList();
            foreach (var item in lstContas)
            {
                lstContasInputModel.Add(new AccountInputModel(item.Id, item.BankName, item.HexColor, item.IconPath, item.Amount));
            }

            return lstContasInputModel;
        }
        public void InsertAccount(AccountInputModel obj)
        {
            var accountModel = new BankModel("", obj.BankName, obj.HexColor, obj.Icon, Convert.ToDouble(obj.Amount));
            accountRepository.InsertAccount(accountModel);
        }

        //AccountTypeRepository
        public List<AccountTypeInputModel> AccountsTypeListByIdAccount(string idAccount)
        {
            List<AccountTypeInputModel> lstAccountTypeInputModel = new List<AccountTypeInputModel>();
            List<AccountTypeModel> lstAccountType = new List<AccountTypeModel>();

            lstAccountType = accountTypeRepository.AccountTypesList(idAccount);
            foreach (var item in lstAccountType)
            {
                lstAccountTypeInputModel.Add(new AccountTypeInputModel(item.Id,
                                                                       item.IdAccount,
                                                                       item.NameAccountType,
                                                                       item.AccountType,
                                                                       item.CountApplications,
                                                                       null, 
                                                                       null, 
                                                                       null, 
                                                                       null,
                                                                       item.Balance));
            }

            return lstAccountTypeInputModel;
        }

        //ConsolidateApplicationRepositoy
        public List<ConsolidateApplicationInputModel> ConsolidateApplicationListByIdAccountType(string idAccountType)
        {

            List<ConsolidateApplicationInputModel> lstContasConsolidateApplicationInputModel = new List<ConsolidateApplicationInputModel>();
            List<ConsolidatedApplicationModel> lstContasAplicacaoConsolidada = new List<ConsolidatedApplicationModel>();

            lstContasAplicacaoConsolidada = consolidatedApplicationRepository.ConsolidateApplicationsList(idAccountType);



            foreach (var item in lstContasAplicacaoConsolidada)
            {

                double total;
                if (item.HasInstallments == false)
                    total = item.IndividualValue;
                else
                    total = item.IndividualValue * item.Installments - (item.PayInstallments == 0 ? +0 : item.IndividualValue * item.PayInstallments);


                lstContasConsolidateApplicationInputModel.Add(new ConsolidateApplicationInputModel(item.Id,
                                                                                                   item.IdAccountType,
                                                                                                   item.Description,
                                                                                                   item.HasInstallments,
                                                                                                   item.PayInstallments,
                                                                                                   item.Installments,
                                                                                                   item.IndividualValue,
                                                                                                   total));
            }

            return lstContasConsolidateApplicationInputModel;
        }

        //FutureApplicationRepository
        public List<FutureApplicationInputModel> FutureApplicationListByIdAccountType(string idAccountType)
        {

            List<FutureApplicationInputModel> lstContasFutureApplicationInputModel = new List<FutureApplicationInputModel>();
            List<FutureApplicationModel> lstContasAplicacaoFutura = new List<FutureApplicationModel>();

            lstContasAplicacaoFutura = futureApplicationRepository.FutureApplicationsList(idAccountType);



            foreach (var item in lstContasAplicacaoFutura)
            {

                double total;
                if (item.HasInstallments == false)
                    total = item.IndividualValue;
                else
                    total = item.IndividualValue * item.Installments - (item.PayInstallments == 0 ? +0 : item.IndividualValue * item.PayInstallments);


                lstContasFutureApplicationInputModel.Add(new FutureApplicationInputModel(item.Id,
                                                                                         item.IdAccountType,
                                                                                         item.Description,
                                                                                         item.HasInstallments,
                                                                                         item.PayInstallments,
                                                                                         item.Installments,
                                                                                         item.IndividualValue,
                                                                                         total));
            }

            return lstContasFutureApplicationInputModel;
        }
        
        //ProgressApplicationRepository

        //AccomplishedApplicationRepository

    }
}
