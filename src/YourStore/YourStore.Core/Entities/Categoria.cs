using System;
using System.Collections.Generic;

namespace YourStore.Core.Entities
{
    public class Categoria : BaseEntity
    {
        public string Nome { get; set; }
        
        // Relacionamentos
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        
        // Navegação
        public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
