using ProjetoOperacoes.InputModels.ApplicationInputModels;
using ProjetoOperacoes.Models.ApplicationsModels;
using ProjetoOperacoes.Repositories;
using System.Collections.Generic;

namespace ProjetoOperacoes.Services.ApplicationServices
{
    public static class ServicesApplication
    {
        private static readonly ApplicationRepository applicationRepository = new ApplicationRepository();

        public static void CreateApplication(ApplicationModel obj)
        {
            var accountModel = new ApplicationModel(obj.IdAccountType,
                                                    obj.RepeatedId,
                                                    obj.Description,
                                                    obj.HasInstallments,
                                                    obj.PaidInstallments,
                                                    obj.Installments,
                                                    obj.IndividualValue,
                                                    obj.TypeApplication);

            applicationRepository.CreateApplication(accountModel);
        }
        public static List<ApplicationInputModel> ReadApplicationListByIdAccountType(string idAccountType)
        {

            List<ApplicationModel> lstApplication = new List<ApplicationModel>();
            List<ApplicationInputModel> lstApplicationInputModel = new List<ApplicationInputModel>();

            lstApplication = applicationRepository.ReadApplicationList(idAccountType);

            foreach (var item in lstApplication)
                lstApplicationInputModel.Add(new ApplicationInputModel(item.ID, item.IdAccountType, item.RepeatedId, item.Description,
                                             item.HasInstallments, item.PaidInstallments, item.Installments, item.IndividualValue, item.TotalValue, item.TypeApplication));

            return lstApplicationInputModel;
        }
        public static void UpdateApplication(ApplicationInputModel obj)
        {
            ApplicationModel application = new ApplicationModel();

            application = applicationRepository.LoadById(obj.Id);


            application.UpdateApplication(obj.IdAccountType,
                                          obj.RepeatedId,
                                          obj.Description,
                                          obj.HasInstallments,
                                          obj.PaidInstallments,
                                          obj.Installments,
                                          obj.IndividualValue,
                                          obj.TypeApplication);

            applicationRepository.UpdateApplication(application);
        }
        public static void DeleteApplication(ApplicationInputModel obj)
        {
            ApplicationModel application = new ApplicationModel();

            application = applicationRepository.LoadById(obj.Id);

            applicationRepository.DeleteApplication(application);
        }

    }
}
