using ProjetoOperacoes.InputModel.AccountInputModel;
using ProjetoOperacoes.InputModel.AccountTypeInputModel;
using ProjetoOperacoes.InputModel.ConsolidateApplicationInputModel;
using ProjetoOperacoes.InputModel.FutureApplicationInputModel;
using ProjetoOperacoes.Models.AccountTypeModels;
using ProjetoOperacoes.Models.ApplicationsModels;
using ProjetoOperacoes.Models.BankModels;
using ProjetoOperacoes.Repositories;
using System;
using System.Collections.Generic;

namespace ProjetoOperacoes
{
    public class Services
    {
        private readonly BankModelRepository accountRepository;
        private readonly AccountTypeModelRepository accountTypeRepository;
        private readonly TbApplicationRepository tbApplicationRepository;
        private readonly ConsolidatedApplicationModelRepository consolidatedApplicationRepository;
        private readonly FutureApplicationModelRepository futureApplicationRepository;
        private readonly ProgressApplicationModelRepository progressApplicationRepository;
        private readonly AccomplishedApplicationModelRepository accomplishedApplicationRepository;

        public Services()
        {
            accountRepository = new BankModelRepository();
            accountTypeRepository = new AccountTypeModelRepository();
            tbApplicationRepository = new TbApplicationRepository();
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
                var teste = accountTypeRepository.AccountTypesList(item.ID);

                foreach (var iten in teste)
                    item.Amount += iten.Balance;

                lstContasInputModel.Add(new AccountInputModel(item.ID, item.BankName, item.HexColor, item.IconPath, item.Amount));
            }

            return lstContasInputModel;
        }
        public void InsertAccount(AccountInputModel obj)
        {
            var accountModel = new BankModel(obj.BankName, obj.HexColor, obj.Icon, Convert.ToDouble(obj.Amount));
            accountRepository.InsertBank(accountModel);
        }

        public void InsertApplication(AccountInputModel obj)
        {
            //var accountModel = new ApplicationModel(obj.BankName, obj.HexColor, obj.Icon, Convert.ToDouble(obj.Amount));
            //tbApplicationRepository.InsertApplication(accountModel);
        }

        //AccountTypeRepository
        public List<AccountTypeInputModel> AccountsTypeListByIdAccount(string idAccount)
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
                                                                       null, 
                                                                       null, 
                                                                       null, 
                                                                       null,
                                                                       item.Balance));
            }

            return lstAccountTypeInputModel;
        }

        //TbApplicationRepositoy
        public List<ConsolidateApplicationInputModel> ConsolidateApplicationListByIdAccountType(string idAccountType)
        {

            List<TbApplication> lstApplication = new List<TbApplication>();
            List<ConsolidatedApplicationModel> lstConsolidatedApplication = new List<ConsolidatedApplicationModel>();
            List<ConsolidateApplicationInputModel> lstContasConsolidateApplicationInputModel = new List<ConsolidateApplicationInputModel>();

            lstApplication = tbApplicationRepository.TbApplicationsList(idAccountType);

            foreach (var item in lstApplication)
                if (item.TypeApplication == ETypeApplication.CONSOLIDATED)
                    lstConsolidatedApplication.Add(new ConsolidatedApplicationModel(item.IdAccountType, item.Description
                        , item.HasInstallments, item.PaidInstallments, item.Installments, item.IndividualValue, item.TypeApplication));


            foreach (var item in lstConsolidatedApplication)
            {

                double total;
                if (item.HasInstallments == false)
                    total = item.IndividualValue;
                else
                    total = item.IndividualValue * item.Installments - (item.PaidInstallments == 0 ? +0 : item.IndividualValue * item.PaidInstallments);


                lstContasConsolidateApplicationInputModel.Add(new ConsolidateApplicationInputModel(item.ID,
                                                                                                   item.IdAccountType,
                                                                                                   item.Description,
                                                                                                   item.HasInstallments,
                                                                                                   item.PaidInstallments,
                                                                                                   item.Installments,
                                                                                                   item.IndividualValue,
                                                                                                   total));
            }

            return lstContasConsolidateApplicationInputModel;
        }
        //FutureApplicationRepository
        public List<FutureApplicationInputModel> FutureApplicationListByIdAccountType(string idAccountType)
        {

            List<TbApplication> lstApplication = new List<TbApplication>();
            List<FutureApplicationModel> lstContasAplicacaoFutura = new List<FutureApplicationModel>();
            List<FutureApplicationInputModel> lstContasFutureApplicationInputModel = new List<FutureApplicationInputModel>();

            lstApplication = tbApplicationRepository.TbApplicationsList(idAccountType);

            foreach (var item in lstApplication)
                if (item.TypeApplication == ETypeApplication.FUTURE)
                    lstContasAplicacaoFutura.Add(new FutureApplicationModel(item.IdAccountType, item.Description
                        , item.HasInstallments, item.PaidInstallments, item.Installments, item.IndividualValue, item.TypeApplication));



            foreach (var item in lstContasAplicacaoFutura)
            {

                double total;
                if (item.HasInstallments == false)
                    total = item.IndividualValue;
                else
                    total = item.IndividualValue * item.Installments - (item.PaidInstallments == 0 ? +0 : item.IndividualValue * item.PaidInstallments);


                lstContasFutureApplicationInputModel.Add(new FutureApplicationInputModel(item.ID,
                                                                                         item.IdAccountType,
                                                                                         item.Description,
                                                                                         item.HasInstallments,
                                                                                         item.PaidInstallments,
                                                                                         item.Installments,
                                                                                         item.IndividualValue,
                                                                                         total));
            }

            return lstContasFutureApplicationInputModel;
        }

    }
}
