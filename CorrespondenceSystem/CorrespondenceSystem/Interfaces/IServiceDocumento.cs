using System;
using System.Collections.Generic;
using CorrespondenceSystem.DomainClasses;
using CorrespondenceSystem.Implementations;
using NHibernate.Mapping;

namespace CorrespondenceSystem.Interfaces
{
    public interface IServiceDocumento
    {
        List<Documento> GetAllDocumentos();
        List<Documento> GetAllDocumentosByFieldAndDate(string campo, DateTime fechaInicio, DateTime fechaFinal);
        List<Documento> GetAllDocumentosByStatus(string status);
        List<Documento> GetAllDocumentosByDepartamento(Departamento departamento);

        Documento GetDocumentoByCodigo(string codigo);
        Documento GetDocumentoById(int id);
        
        void InsertDocumento(Documento documento);
        void UpdateDocumento(Documento documento);
        void UpdateStatus(Documento documento);
    }
}