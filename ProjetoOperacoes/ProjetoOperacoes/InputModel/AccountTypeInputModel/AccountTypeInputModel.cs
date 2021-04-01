using System.Collections.Generic;

namespace ProjetoOperacoes.InputModel.AccountTypeInputModel
{
    public class AccountTypeInputModel
    {
        public AccountTypeInputModel()
        {
               
        }
        public AccountTypeInputModel(string id, 
                                     string idAccount, 
                                     string nameAccountType, 
                                     int accountType,
                                     int countApplications,
                                     List<ConsolidateApplicationInputModel.ConsolidateApplicationInputModel> consolidatedItems,
                                     List<FutureApplicationInputModel.FutureApplicationInputModel> futureItems,
                                     List<ProgressApplicationInputModel.ProgressApplication> progressItems,
                                     List<AccomplishedApplicationInputModel.AccomplishedApplicationInputModel> accomplhishedItems,
                                     double balance)
        {
            ID = id;
            IdAccount = idAccount;
            NameAccountType = nameAccountType;
            AccountType = accountType;
            CountApplications = countApplications;
            ConsolidatedItems = consolidatedItems;
            FutureItems = futureItems;
            ProgressItems = progressItems;
            AccomplishedItems = accomplhishedItems;
            Balance = balance;
        }

        public string ID { get; set; }
        public string IdAccount { get; set; }
        public string NameAccountType { get; set; }
        public int AccountType { get; set; }
        public int CountApplications { get; set; }
        public List<ConsolidateApplicationInputModel.ConsolidateApplicationInputModel> ConsolidatedItems { get; set; }
        public List<FutureApplicationInputModel.FutureApplicationInputModel> FutureItems { get; set; }
        public List<ProgressApplicationInputModel.ProgressApplication> ProgressItems { get; set; }
        public List<AccomplishedApplicationInputModel.AccomplishedApplicationInputModel> AccomplishedItems { get; set; }
        public double Balance { get; set; }
    }
}
