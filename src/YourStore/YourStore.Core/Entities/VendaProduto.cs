using System;

namespace YourStore.Core.Entities
{
    public class VendaProduto : BaseEntity
    {
        public decimal Desconto { get; set; }
        
        // Relacionamentos
        public Guid VendaId { get; set; }
        public virtual Venda Venda { get; set; }
        
        public Guid ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}
