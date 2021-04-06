using ProjetoOperacoes.Models.AccountTypeModels;

namespace ProjetoOperacoes.InputModels
{
    public class AccountTypeInputModel
    {
        public AccountTypeInputModel()
        {
               
        }
        public AccountTypeInputModel(string id, 
                                     string idBank, 
                                     string nameAccountType, 
                                     EAccountType accountType,
                                     //List<ConsolidatedInputModel.ConsolidatedInputModel> consolidatedItems,
                                     //List<FutureInputModel.FutureInputModel> futureItems,
                                     //List<ProgressApplicationInputModel.ProgressApplication> progressItems,
                                     //List<AccomplishedApplicationInputModel.AccomplishedInputModel> accomplhishedItems,
                                     double balance)
        {
            ID = id;
            IdBank = idBank;
            NameAccountType = nameAccountType;
            AccountType = accountType;
            //ConsolidatedItems = consolidatedItems;
            //FutureItems = futureItems;
            //ProgressItems = progressItems;
            //AccomplishedItems = accomplhishedItems;
            Balance = balance;
        }

        public string ID { get; set; }
        public string IdBank { get; set; }
        public string NameAccountType { get; set; }
        public EAccountType AccountType { get; set; }
        //public List<ConsolidatedInputModel.ConsolidatedInputModel> ConsolidatedItems { get; set; }
        //public List<FutureInputModel.FutureInputModel> FutureItems { get; set; }
        //public List<ProgressApplicationInputModel.ProgressApplication> ProgressItems { get; set; }
        //public List<AccomplishedApplicationInputModel.AccomplishedInputModel> AccomplishedItems { get; set; }
        public double Balance { get; set; }
    }
}
