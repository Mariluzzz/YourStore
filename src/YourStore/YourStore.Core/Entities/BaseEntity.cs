using System;

namespace YourStore.Core.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DataRegistro { get; set; } = DateTime.UtcNow;
        public bool Ativo { get; set; } = true;
    }
}
