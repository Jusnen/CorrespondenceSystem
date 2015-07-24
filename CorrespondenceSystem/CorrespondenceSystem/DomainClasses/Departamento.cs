using CorrespondenceSystem.Implementations;

namespace CorrespondenceSystem.DomainClasses
{
    public class Departamento : Entity<int>
    {
        public virtual string descripcion { get; set; }
        public virtual TipoDepartamento tipoDepartamento { get; set; }

        public Departamento()
        {
            tipoDepartamento = new TipoDepartamento();
        }
    }
}