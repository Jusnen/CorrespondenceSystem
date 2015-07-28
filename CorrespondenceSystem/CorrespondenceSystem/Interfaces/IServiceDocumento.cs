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
        List<Documento> GetAllDocumentosByStatus(string status);
        List<Documento> GetAllDocumentosByDepartamento(int idDepartamento);
        List<Documento> GetAllDocumentosByDepartamento(int idDepartamento, DateTime fechaInicio, DateTime fechaFinal);

        Documento GetDocumentoByCodigo(string codigo);
        Documento GetDocumentoById(int id);
        
        void InsertDocumento(Documento documento);
        void UpdateDocumento(Documento documento);
        void UpdateStatus(Documento documento);
    }
}