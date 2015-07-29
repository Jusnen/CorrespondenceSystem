using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using CorrespondenceSystem.DomainClasses;
using CorrespondenceSystem.Services;

namespace CorrespondenceSystem.ViewModel.Documento
{
    public class DocumentoCrearViewModel
    {
        private const string CampoRequerido = "Campo requerido";
        
        public SelectList ddlRegional { get; set; }
        public SelectList ddlDestinatarios { get; set; }

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