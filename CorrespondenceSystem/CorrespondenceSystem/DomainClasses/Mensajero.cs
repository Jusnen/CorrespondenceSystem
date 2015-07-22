using CorrespondenceSystem.Implementations;

namespace CorrespondenceSystem.DomainClasses
{
    public class Mensajero : Entity<int>
    {
        public virtual string descripcion { get; set; }
    }
}