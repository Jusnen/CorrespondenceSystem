namespace CorrespondenceSystem.Interfaces
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey id { get; set; }
    }
}