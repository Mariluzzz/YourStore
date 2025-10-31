using System;
using System.Collections.Generic;

namespace YourStore.Core.Entities
{
    public class Produto : BaseEntity
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Etiqueta { get; set; }
        public string Precificacao { get; set; }
        public int QuantidadeEntrada { get; set; }
        public int Estoque { get; set; }
        
        // Relacionamentos
        public Guid FornecedorId { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        
        public Guid CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        
        // Navegação
        public virtual ICollection<VendaProduto> VendaProdutos { get; set; } = new List<VendaProduto>();
    }
}
