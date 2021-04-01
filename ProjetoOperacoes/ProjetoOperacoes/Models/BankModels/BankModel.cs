using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoOperacoes.Models.BankModels
{
    [Table("tb_bank")]
    public class BankModel : Identity
    {
        public BankModel()
        {

        }

        public BankModel(string bankName, string hexColor, string iconPath, double amount)
        {
            BankName = bankName;
            HexColor = hexColor;
            IconPath = iconPath;
            Amount = amount;
        }
        

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
