using System;
using CorrespondenceSystem.Implementations;

namespace CorrespondenceSystem.DomainClasses
{
    public class Documento : Entity<int>
    {
        public Documento()
        {
            departamento = new Departamento();
            fechaRegistroUsuario = DateTime.Now;
            fechaCreacion = DateTime.Now;
        }

        public virtual string codigo { get; set; }
        public virtual DateTime fechaCreacionUsuario { get; set; }
        public virtual DateTime fechaRegistroUsuario { get; set; }
        public virtual string asunto { get; set; }
        public virtual Departamento departamento { get; set; }
        public virtual DateTime fechaCreacion { get; set; }
        public virtual DateTime? fechaModificacion { get; set; }
        public virtual int usuarioCreacion { get; set; }
        public virtual int usuarioModificacion { get; set; }
    }
}