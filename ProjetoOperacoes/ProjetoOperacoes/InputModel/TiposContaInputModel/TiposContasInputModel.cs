using System.Collections.Generic;

namespace ProjetoOperacoes.InputModel.TiposContaInputModel
{
    public class TiposContasInputModel
    {
        public TiposContasInputModel(string iD, 
                                     string idContas, 
                                     string nome, 
                                     int tipoConta,
                                     int quantidadeDeAplicacao,
                                     List<AplicacaoConsolidadaInputModel.AplicacaoConsolidadaInputModel> itensConsolidadas,
                                     List<AplicacaoFutura.AplicacaoFutura> itensfuturos,
                                     List<AplicacaoEmAndamentoInputModel.AplicacaoEmAndamentoInputModel> itensEmAndamento,
                                     List<AplicacaoRealizada.AplicacaoRealizada> itensRealizados,
                                     double valorTotalConta)
        {
            ID = iD;
            IdContas = idContas;
            Nome = nome;
            TipoConta = tipoConta;
            QuantidadeDeAplicacao = quantidadeDeAplicacao;
            ItensConsolidados = itensConsolidadas;
            ItensFuturos = itensfuturos;
            ItensEmAndamento = itensEmAndamento;
            ItensRealizados = itensRealizados;
            ValorTotalConta = valorTotalConta;
        }

        public string ID { get; set; }
        public string IdContas { get; set; }
        public string Nome { get; set; }
        public int TipoConta { get; set; }
        public int QuantidadeDeAplicacao { get; set; }
        public List<AplicacaoConsolidadaInputModel.AplicacaoConsolidadaInputModel> ItensConsolidados { get; set; }
        public List<AplicacaoFutura.AplicacaoFutura> ItensFuturos { get; set; }
        public List<AplicacaoEmAndamentoInputModel.AplicacaoEmAndamentoInputModel> ItensEmAndamento { get; set; }
        public List<AplicacaoRealizada.AplicacaoRealizada> ItensRealizados { get; set; }
        public double ValorTotalConta { get; set; }
    }
}
