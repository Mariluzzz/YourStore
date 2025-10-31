using System;

namespace YourStore.Core.Entities
{
    public class FornecedorPagamento : BaseEntity
    {
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        
        // Relacionamentos
        public Guid FornecedorId { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        
        public Guid TipoPagamentoId { get; set; }
        public virtual TipoPagamento TipoPagamento { get; set; }
    }
}
