using System;
using System.Collections.Generic;
using SistemaCorrespondencia.MVC.DomainClasses;

namespace SistemaCorrespondencia.MVC.Interfaces
{
    public interface IServiceDocumento
    {
        List<Documento> GetAllDocumentos();
        List<Documento> GetAllDocumentosByStatus(string status);
        List<Documento> GetAllDocumentosByDepartamento(int idDepartamento);
        List<Documento> GetAllDocumentosByDepartamento(int idDepartamento, DateTime fechaInicio, DateTime fechaFinal);
        List<Documento> GetAllDocumentosByTipoDepartamento(int idTipoDepartamento);

        List<TipoEntrada> GetAllTipoEntrada();

        Documento GetDocumentoByCodigo(string codigo);
        Documento GetDocumentoById(int id);
        void InsertDocumento(Documento documento);
        void UpdateDocumento(Documento documento);
        void UpdateStatus(Documento documento);
    }
}