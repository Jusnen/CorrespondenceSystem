using System;
using System.Collections.Generic;
using CorrespondenceSystem.DomainClasses;
using NHibernate.Mapping;

namespace CorrespondenceSystem.Interfaces
{
    public interface IServiceDocumento
    {
        List<Documento> GetAllDocumento();
        List<Documento> GetAllDocumentoFromRemitente(string remitente);
        List<Documento> GetAllDocumentoFromFechaRegistrado(DateTime fechaInicio, DateTime fechaFinal);
        List<Documento> GetAllDocumentoFromFechaCracion(DateTime fechaInicio, DateTime fechaFinal);
        Documento GetDocumentoByCodigo(string codigo);
        Documento GetDocumentoById(int id);
        void InsertDocumento(Documento documento);
        void UpdateDocumento(Documento documento);
        void UpdateStatus(Documento documento);
    }
}