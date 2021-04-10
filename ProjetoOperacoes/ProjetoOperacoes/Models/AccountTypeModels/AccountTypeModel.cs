using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoOperacoes.Models.AccountTypeModels
{
    [Table("tb_accounttype")]
    public class AccountTypeModel
    {

        public AccountTypeModel()
        {

        }

        public AccountTypeModel(string idBank, string nameAccountType, EAccountType accountType, double balance)
        {
            IdBank = idBank;
            NameAccountType = nameAccountType;
            AccountType = accountType;
            Balance = balance;
        }

        [Column("id")]
        public string ID { get; set; }

        [Column("idbank")]
        public string IdBank { get; set; }

        [Column("nameaccounttype")]
        public string NameAccountType { get; set; }
        
        [Column("accounttype")]
        public EAccountType AccountType { get; set; }
        
        [Column("balance")]
        public double Balance { get; set; }

        public void UpdateAccounTypeModel(string id,
                                          string idBank, 
                                          string nameAccountType, 
                                          EAccountType accountType, 
                                          double balance)
        {
            ID = id;
            IdBank = idBank;
            NameAccountType = nameAccountType;
            AccountType = accountType;
            Balance = balance;

        }
    }
}
