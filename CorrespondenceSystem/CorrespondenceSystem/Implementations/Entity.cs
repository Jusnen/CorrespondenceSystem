namespace CorrespondenceSystem.Implementations
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey id { get; set; }
    }

    public class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey id { get; set; }
    }
}