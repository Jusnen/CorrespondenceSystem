using System;
using System.Collections.Generic;
using CorrespondenceSystem.Implementations;

namespace CorrespondenceSystem.DomainClasses
{
    public class Usuario : Entity<int>
    {
        public Usuario()
        {
            tipoUsuario = new TipoUsuario();
            fechaRegistro = DateTime.Now;
        }

        public virtual string nombre { get; set; }
        public virtual string correo { get; set; }
        public virtual TipoUsuario tipoUsuario { get; set; }
        public virtual ICollection<Movimiento> Movimientos { get; set; }
        public virtual DateTime fechaRegistro { get; set; }
        public virtual DateTime fechaModificacion { get; set; }
        public virtual int usuarioCreacion { get; set; }
        public virtual int usuarioModificacion { get; set; }
    }
}