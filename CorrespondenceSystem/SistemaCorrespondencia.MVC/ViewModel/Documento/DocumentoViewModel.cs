using System;
using SistemaCorrespondencia.MVC.DomainClasses;

namespace SistemaCorrespondencia.MVC.ViewModel.Documento
{
    public class DocumentoViewModel
    {
        public string codigo { get; set; }
        public DateTime fechaCreacionUsuario { get; set; }
        public DateTime fechaRegistroUsuario { get; set; }
        public string asunto { get; set; }
        public Departamento departamento { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime? fechaModificacion { get; set; }
        public int usuarioCreacion { get; set; }
        public int usuarioModificacion { get; set; }
        
    }
}