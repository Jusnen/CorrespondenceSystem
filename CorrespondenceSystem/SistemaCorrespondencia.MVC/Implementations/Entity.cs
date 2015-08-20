using SistemaCorrespondencia.MVC.Interfaces;

namespace SistemaCorrespondencia.MVC.Implementations
{
    public class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
    }
}