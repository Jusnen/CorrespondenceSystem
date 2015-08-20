using SistemaCorrespondencia.MVC.Implementations;

namespace SistemaCorrespondencia.MVC.DomainClasses
{
    public class TipoDepartamento : Entity<int>
    {
        public virtual string descripcion { get; set; }
    }
}