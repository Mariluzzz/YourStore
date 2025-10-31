using System;
using System.Collections.Generic;

namespace YourStore.Core.Entities
{
    public class Fornecedor : BaseEntity
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Documento { get; set; }
        public DateTime DataFechamento { get; set; } = DateTime.UtcNow.AddDays(30);
        public int Porcentual { get; set; }
        public int PorcentualUser { get; set; }
        
        // Relacionamentos
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        
        // Navegação
        public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
        public virtual ICollection<FornecedorPagamento> FornecedorPagamentos { get; set; } = new List<FornecedorPagamento>();
    }
}
