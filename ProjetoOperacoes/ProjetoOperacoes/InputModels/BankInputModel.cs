﻿namespace ProjetoOperacoes.InputModels
{
    public class BankInputModel
    {
        public BankInputModel()
        {

        }
        public BankInputModel(string id, string bankName, string hexColor, string icon, double amount)
        {
            ID = id;
            BankName = bankName;
            HexColor = hexColor;
            Icon = icon;
            Amount = amount;
        }

        public string ID { get; set; }
        public string BankName { get; set; }
        public string HexColor { get; set; }
        public string Icon { get; set; }
        public double Amount { get; set; }
    }
}