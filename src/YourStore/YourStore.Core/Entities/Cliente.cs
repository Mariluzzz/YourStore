using System;
using System.Collections.Generic;

namespace YourStore.Core.Entities
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Documento { get; set; }
        public bool Salao { get; set; }
        
        // Relacionamentos
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        
        // Navegação
        public virtual ICollection<Venda> Vendas { get; set; } = new List<Venda>();
    }
}
