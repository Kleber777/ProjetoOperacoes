using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoOperacoes.Models.BankModels
{
    [Table("tb_bank")]
    public class BankModel
    {
        public BankModel()
        {

        }

        public BankModel(string bankName, string hexColor, string iconPath, double amount)
        {
            ID = Guid.NewGuid().ToString();
            BankName = bankName;
            HexColor = hexColor;
            IconPath = iconPath;
            Amount = amount;
        }
        

        [Column("id")]
        public string ID { get; set; }

        [Column("bankname")]
        public string BankName { get; set; }

        [Column("hexcolor")]
        public string HexColor { get; set; }

        [Column("iconpath")]
        public string IconPath { get; set; }

        [NotMapped]
        public double Amount { get; set; }
    }
}
