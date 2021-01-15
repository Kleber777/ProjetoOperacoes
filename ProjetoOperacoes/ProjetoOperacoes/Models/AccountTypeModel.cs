using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoOperacoes.Models
{
    [Table("tb_accounttype")]
    public class AccountTypeModel
    {

        public AccountTypeModel()
        {

        }
        [Column("id")]
        public string Id { get; set; }

        [Column("idaccount")]
        public string IdAccount { get; set; }

        [Column("nameaccounttype")]
        public string NameAccountType { get; set; }

        //1 = Conta Corrente, 2 = Conta Poupança
        [Column("accounttype")]
        public int AccountType   { get; set; }

        [Column("countapplications")]
        public int CountApplications   { get; set; }
        
        [Column("totalaccountvalue")]
        public double TotalAccountValue { get; set; }
    }
}
