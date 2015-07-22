using CorrespondenceSystem.Implementations;

namespace CorrespondenceSystem.DomainClasses
{
    public class TipoUsuario : Entity<int>
    {
        public virtual string descripcion { get; set; }
    }
}