using System;
using System.Collections.Generic;

namespace YourStore.Core.Entities
{
    public class Venda : BaseEntity
    {
        // Relacionamentos
        public Guid ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        
        // Navegação
        public virtual ICollection<VendaProduto> VendaProdutos { get; set; } = new List<VendaProduto>();
        public virtual ICollection<VendaPagamento> VendaPagamentos { get; set; } = new List<VendaPagamento>();
    }
}
