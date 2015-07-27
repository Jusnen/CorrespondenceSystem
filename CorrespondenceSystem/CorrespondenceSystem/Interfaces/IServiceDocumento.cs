using System;
using System.Collections.Generic;
using CorrespondenceSystem.DomainClasses;
using CorrespondenceSystem.Implementations;
using NHibernate.Mapping;

namespace CorrespondenceSystem.Interfaces
{
    public interface IServiceDocumento
    {
        Documento GetDocumentoByCodigo(string codigo);
        Documento GetDocumentoById(int id);
        
        void InsertDocumento(Documento documento);
        List<Documento> GetAllDocumentoByDepartamento(Departamento departamento);
        void UpdateStatus(Documento documento);

        List<Documento> GetAllDocumento();
        List<Documento> GetAllDocumentoByFieldAndDate(string campo, DateTime fechaInicio, DateTime fechaFinal);

        List<Documento> GetAllDocumentoByStatus(string status);
        
        List<Movimiento> GetAllMovimiento(Documento documento);
        
        void UpdateDocumento(Documento documento);
    }
}