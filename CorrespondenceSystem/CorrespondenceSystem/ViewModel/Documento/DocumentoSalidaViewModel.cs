using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using CorrespondenceSystem.DomainClasses;

namespace CorrespondenceSystem.ViewModel.Documento
{
    public class DocumentoSalidaViewModel
    {
        public List<DomainClasses.Documento> documentos { get; set; } 
        public List<Departamento> destinararios { get; set; }

        
        public SelectList ddlDestinatarios {get; set; }

        [Display(Name = "No. de Oficio")]
        [Required(ErrorMessage = "Seleccione 1 de la tabla")]
        public int idDocumento { get; set; }

        [Display(Name = "Destinatarios")]
        [Required(ErrorMessage = "Seleccione 1")]
        public int idDestinatario { get; set; }

    }
}