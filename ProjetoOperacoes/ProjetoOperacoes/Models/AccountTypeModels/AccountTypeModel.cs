using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoOperacoes.Models.AccountTypeModels
{
    [Table("tb_accounttype")]
    public class AccountTypeModel : Identity
    {

        public AccountTypeModel()
        {

        }

        [Column("idbank")]
        public string IdBank { get; set; }

        [Column("nameaccounttype")]
        public string NameAccountType { get; set; }
        
        [Column("accounttype")]
        public EAccountType AccountType { get; set; }
        
        [Column("balance")]
        public double Balance { get; set; }
    }
}
