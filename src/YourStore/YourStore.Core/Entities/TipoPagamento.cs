using System;
using System.Collections.Generic;

namespace YourStore.Core.Entities
{
    public class TipoPagamento : BaseEntity
    {
        public string Nome { get; set; }
        
        // Relacionamentos
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        
        // Navegação
        public virtual ICollection<VendaPagamento> VendaPagamentos { get; set; } = new List<VendaPagamento>();
        public virtual ICollection<FornecedorPagamento> FornecedorPagamentos { get; set; } = new List<FornecedorPagamento>();
    }
}
