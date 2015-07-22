using CorrespondenceSystem.Interfaces;

namespace CorrespondenceSystem.Implementations
{
    public class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey id { get; set; }
    }
}