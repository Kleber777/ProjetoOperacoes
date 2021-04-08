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
