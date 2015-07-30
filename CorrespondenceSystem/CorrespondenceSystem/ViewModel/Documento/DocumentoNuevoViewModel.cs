using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using CorrespondenceSystem.DomainClasses;

namespace CorrespondenceSystem.ViewModel.Documento
{
    public class DocumentoNuevoViewModel
    {
        private const string CampoRequerido = "Campo {0} requerido";

        public SelectList ddlRegional { get; set; }
        public List<Departamento> departamentosInternos { get; set; }
        public List<Departamento> departamentosOpreaciones { get; set; }
        public List<Departamento> departamentosExternos { get; set; }

        [Display(Name = "No. Oficio")]
        [Required(ErrorMessage = CampoRequerido)]
        public string noOficio { get; set; }

        [Display(Name = "Fecha del Documento")]
        [Required(ErrorMessage = CampoRequerido)]
        public string fechaDocumento { get; set; }

        [Display(Name = "Regional")]
        [Required(ErrorMessage = CampoRequerido)]
        public int regional { get; set; }

        [Display(Name = "Asunto")]
        [Required(ErrorMessage = CampoRequerido)]
        public string asunto { get; set; }

        [Display(Name = "Fecha Recibido")]
        [Required(ErrorMessage = CampoRequerido)]
        public string fechaRecibido { get; set; }

        [Display(Name = "Destinatarios")]
        [Required(ErrorMessage = CampoRequerido)]
        public int idDepartamento { get; set; }

    }
}