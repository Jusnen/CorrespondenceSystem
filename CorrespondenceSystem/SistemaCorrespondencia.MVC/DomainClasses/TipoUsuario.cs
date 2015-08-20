using SistemaCorrespondencia.MVC.Implementations;

namespace SistemaCorrespondencia.MVC.DomainClasses
{
    public class TipoUsuario : Entity<int>
    {
        public virtual string descripcion { get; set; }
    }
}