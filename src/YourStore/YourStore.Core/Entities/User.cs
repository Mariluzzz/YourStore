using System;
using System.Collections.Generic;
using YourStore.Core.Enums;

namespace YourStore.Core.Entities
{
    public class User : BaseEntity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; } // Será criptografada na camada de aplicação
        public bool Admin { get; set; }
        
        // Navegação
        public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
        public virtual ICollection<Fornecedor> Fornecedores { get; set; } = new List<Fornecedor>();
        public virtual ICollection<Categoria> Categorias { get; set; } = new List<Categoria>();
        public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
        public virtual ICollection<Venda> Vendas { get; set; } = new List<Venda>();
        public virtual ICollection<VendaProduto> VendaProdutos { get; set; } = new List<VendaProduto>();
        public virtual ICollection<FornecedorPagamento> FornecedorPagamentos { get; set; } = new List<FornecedorPagamento>();
    }
}
