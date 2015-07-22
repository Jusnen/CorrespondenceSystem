using CorrespondenceSystem.Implementations;

namespace CorrespondenceSystem.DomainClasses
{
    public class TipoDepartamento : Entity<int>
    {
        public virtual string descripcion { get; set; }
    }
}