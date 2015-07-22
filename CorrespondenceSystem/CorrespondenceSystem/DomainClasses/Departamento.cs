using CorrespondenceSystem.Implementations;

namespace CorrespondenceSystem.DomainClasses
{
    public class Departamento : Entity<int>
    {
        public virtual int idDepartamento { get; set; }
        public virtual string descripcion { get; set; }
        public virtual TipoDepartamento tipoDepartamento { get; set; }

        public Departamento()
        {
            tipoDepartamento = new TipoDepartamento();
        }
    }
}