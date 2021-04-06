using ProjetoOperacoes.InputModels;
using ProjetoOperacoes.InputModels.ApplicationInputModels;
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
        private readonly ApplicationRepository tbApplicationRepository;

        public Services()
        {
            accountRepository = new BankModelRepository();
            accountTypeRepository = new AccountTypeModelRepository();
            tbApplicationRepository = new ApplicationRepository();
        }

        //BankRepository
        public List<BankInputModel> BankList()
        {
            List<BankInputModel> lstContasInputModel = new List<BankInputModel>();
            List<BankModel> lstContas = new List<BankModel>();

            lstContas = accountRepository.BankList();
            
            foreach (var item in lstContas)
            {
                var teste = accountTypeRepository.AccountTypesList(item.ID);

                foreach (var iten in teste)
                    item.Amount += iten.Balance;

                lstContasInputModel.Add(new BankInputModel(item.ID, item.BankName, item.HexColor, item.IconPath, item.Amount));
            }

            return lstContasInputModel;
        }
        public void InsertBank(BankInputModel obj)
        {
            var accountModel = new BankModel(obj.BankName, obj.HexColor, obj.Icon, Convert.ToDouble(obj.Amount));
            accountRepository.InsertBank(accountModel);
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
                                                                       //null, 
                                                                       //null, 
                                                                       //null, 
                                                                       //null,
                                                                       item.Balance));
            }

            return lstAccountTypeInputModel;
        }

        //ApplicationRepository
        public List<ApplicationInputModel> ApplicationListByIdAccountType(string idAccountType)
        {

            List<ApplicationModel> lstApplication = new List<ApplicationModel>();
            List<ApplicationInputModel> lstApplicationInputModel = new List<ApplicationInputModel>();

            lstApplication = tbApplicationRepository.ApplicationList(idAccountType);

            foreach (var item in lstApplication)
                lstApplicationInputModel.Add(new ApplicationInputModel());

            return lstApplicationInputModel;
        }

        public void InsertApplication(BankInputModel obj)
        {
            //var accountModel = new ApplicationModel(obj.BankName, obj.HexColor, obj.Icon, Convert.ToDouble(obj.Amount));
            //tbApplicationRepository.InsertApplication(accountModel);
        }

    }
}

#region REMOVER
//public List<ConsolidatedInputModel> ConsolidateApplicationListByIdAccountType(string idAccountType)
//{

//    List<ApplicationModel> lstApplication = new List<ApplicationModel>();
//    List<ConsolidatedApplication> lstConsolidatedApplication = new List<ConsolidatedApplication>();
//    List<ConsolidatedInputModel> lstContasConsolidatedInputModel = new List<ConsolidatedInputModel>();

//    lstApplication = tbApplicationRepository.ApplicationList(idAccountType);

//    //foreach (var item in lstApplication)
//    //    if (item.TypeApplication == ETypeApplication.CONSOLIDATED)
//    //        lstConsolidatedApplication.Add(new ConsolidatedApplicationModel(item.IdAccountType, item.Description
//    //            , item.HasInstallments, item.PaidInstallments, item.Installments, item.IndividualValue, item.TypeApplication));


//    //foreach (var item in lstConsolidatedApplication)
//    //{

//    //    double total;
//    //    if (item.HasInstallments == false)
//    //        total = item.IndividualValue;
//    //    else
//    //        total = item.IndividualValue * item.Installments - (item.PaidInstallments == 0 ? +0 : item.IndividualValue * item.PaidInstallments);


//    //    lstContasConsolidatedInputModel.Add(new ConsolidatedInputModel(item.ID,
//    //                                                                                       item.IdAccountType,
//    //                                                                                       item.Description,
//    //                                                                                       item.HasInstallments,
//    //                                                                                       item.PaidInstallments,
//    //                                                                                       item.Installments,
//    //                                                                                       item.IndividualValue,
//    //                                                                                       total));
//    //}

//    return lstContasConsolidatedInputModel;
//}
////FutureApplicationRepository
//public List<FutureInputModel> FutureApplicationListByIdAccountType(string idAccountType)
//{

//    List<FutureApplication> lstContasAplicacaoFutura = new List<FutureApplication>();
//    List<FutureInputModel> lstContasFutureInputModel = new List<FutureInputModel>();

//    //lstApplication = tbApplicationRepository.TbApplicationsList(idAccountType);

//    //foreach (var item in lstApplication)
//    //    if (item.TypeApplication == ETypeApplication.FUTURE)
//    //        lstContasAplicacaoFutura.Add(new FutureApplicationModel(item.IdAccountType, item.Description
//    //            , item.HasInstallments, item.PaidInstallments, item.Installments, item.IndividualValue, item.TypeApplication));



//    //foreach (var item in lstContasAplicacaoFutura)
//    //{

//    //    double total;
//    //    if (item.HasInstallments == false)
//    //        total = item.IndividualValue;
//    //    else
//    //        total = item.IndividualValue * item.Installments - (item.PaidInstallments == 0 ? +0 : item.IndividualValue * item.PaidInstallments);


//    //    lstContasFutureInputModel.Add(new FutureInputModel(item.ID,
//    //                                                                             item.IdAccountType,
//    //                                                                             item.Description,
//    //                                                                             item.HasInstallments,
//    //                                                                             item.PaidInstallments,
//    //                                                                             item.Installments,
//    //                                                                             item.IndividualValue,
//    //                                                                             total));
//    //}

//    return lstContasFutureInputModel;
//}

#endregion
