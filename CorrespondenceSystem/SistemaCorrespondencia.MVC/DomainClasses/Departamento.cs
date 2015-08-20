using SistemaCorrespondencia.MVC.Implementations;

namespace SistemaCorrespondencia.MVC.DomainClasses
{
    public class Departamento : Entity<int>
    {
        public Departamento()
        {
            tipoDepartamento = new TipoDepartamento();
        }

        public virtual string descripcion { get; set; }
        public virtual TipoDepartamento tipoDepartamento { get; set; }
    }
}