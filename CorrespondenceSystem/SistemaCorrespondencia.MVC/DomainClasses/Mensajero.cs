using SistemaCorrespondencia.MVC.Implementations;

namespace SistemaCorrespondencia.MVC.DomainClasses
{
    public class Mensajero : Entity<int>
    {
        public virtual string descripcion { get; set; }
    }
}