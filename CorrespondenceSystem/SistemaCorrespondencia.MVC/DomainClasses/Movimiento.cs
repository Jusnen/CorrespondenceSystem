using System;
using SistemaCorrespondencia.MVC.Implementations;

namespace SistemaCorrespondencia.MVC.DomainClasses
{
    public class Movimiento : Entity<int>
    {
        public Movimiento()
        {
            documento = new Documento();
            mensajero = new Mensajero();
            tipoMovimiento = new TipoMovimiento();
            departamento = new Departamento();
            usuario = new Usuario();
            fecha = DateTime.Now;
            fechaCreacion = DateTime.Now;
        }

        public virtual Documento documento { get; set; }
        public virtual Mensajero mensajero { get; set; }
        public virtual TipoMovimiento tipoMovimiento { get; set; }
        public virtual Departamento departamento { get; set; }
        public virtual Usuario usuario { get; set; }
        public virtual DateTime fecha { get; set; }
        public virtual DateTime fechaCreacion { get; set; }
        public virtual DateTime? fechaModificacion { get; set; }
        public virtual int usuarioCreacion { get; set; }
        public virtual int usuarioModificacion { get; set; }
    }
}