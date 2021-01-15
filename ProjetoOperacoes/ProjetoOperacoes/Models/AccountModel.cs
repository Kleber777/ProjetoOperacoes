using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoOperacoes.Models
{
    [Table("tb_account")]
    public class AccountModel
    {
        public AccountModel()
        {

        }

        public AccountModel(string id, string bankName, string hexColor, string iconPath, double amount)
        {
            Id = Guid.NewGuid().ToString();
            BankName = bankName;
            HexColor = hexColor;
            IconPath = iconPath;
            Amount = amount;
        }

        [Column ("id")]
        public string Id { get; set; }

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
