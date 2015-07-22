using CorrespondenceSystem.Implementations;

namespace CorrespondenceSystem.DomainClasses
{
    public class TipoMovimiento : Entity<int>
    {
        public virtual string descripcion { get; set; }
    }
}