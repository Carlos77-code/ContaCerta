namespace ContaCerta.Models
{
    public class DespesasModel
    {
        public int Id { get; set; }

        public string Categoria { get; set; }

        public string Descricao { get; set; }

        public double ValorDaParcela { get; set; }

        public string StatusDoMes { get; set; }

        public string FormaDePagamento { get; set; }

        public int QuantidadeParcelasPagas { get; set; }

        public int QuantiadeDeParcelasFaltantes { get; set; }

        public int QuantidadeTotalDeParcelas { get; set; }

        public double ValorTotalAPagar { get; set; }

        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
