using System;

namespace YourStore.Core.Entities
{
    public class VendaPagamento : BaseEntity
    {
        public decimal ValorTotalSemDesconto { get; set; }
        public decimal ValorTotalComDesconto { get; set; }
        public int QuantidadeParcelas { get; set; }
        public decimal DescontoTotais { get; set; }
        public DateTime DataPagamento { get; set; }
        
        // Relacionamentos
        public Guid VendaId { get; set; }
        public virtual Venda Venda { get; set; }
        
        public Guid TipoPagamentoId { get; set; }
        public virtual TipoPagamento TipoPagamento { get; set; }
    }
}
