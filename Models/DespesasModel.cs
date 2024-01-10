using System.ComponentModel.DataAnnotations;

namespace ContaCerta.Models
{
    public class DespesasModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Selecione a categoria")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Digite a descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Digite a o valor da parcela")]
        public double ValorDaParcela { get; set; }

        [Required(ErrorMessage = "Selecione se  já está pago ou não")]
        public string StatusDoMes { get; set; }

        [Required(ErrorMessage = "Selecione a forma de pagamento")]
        public string FormaDePagamento { get; set; }

        [Required(ErrorMessage = "Digite a quantidade de parcelas pagas")]
        public int QuantidadeParcelasPagas { get; set; }

        public int QuantiadeDeParcelasFaltantes { get; set; }

        [Required(ErrorMessage = "Digite a quantidade total de parcelas")]
        public int QuantidadeTotalDeParcelas { get; set; }

        public double ValorTotalAPagar { get; set; }

        public double ValorTotalPago { get; set; }

        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
