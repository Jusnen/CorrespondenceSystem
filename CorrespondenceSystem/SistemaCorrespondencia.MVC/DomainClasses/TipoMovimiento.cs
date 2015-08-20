using SistemaCorrespondencia.MVC.Implementations;

namespace SistemaCorrespondencia.MVC.DomainClasses
{
    public class TipoMovimiento : Entity<int>
    {
        public virtual string descripcion { get; set; }
    }
}