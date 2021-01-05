using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoOperacoes.Models
{
    [Table("tb_account")]
    public class AccountModel
    {
        public AccountModel()
        {

        }
        [Column ("id")]
        public int Id { get; set; }

        [Column("bankname")]
        public string BankName { get; set; }

        [Column("hexcolor")]
        public string HexColor { get; set; }

        [Column("iconpath")]
        public string IconPath { get; set; }

        [Column("amount")]
        public double Amount { get; set; }
    }
}
