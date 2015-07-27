using System;
using System.Collections.Generic;
using CorrespondenceSystem.DomainClasses;

namespace CorrespondenceSystem.Interfaces
{
    public interface IServiceMovimiento
    {
        void InsertMovimiento(Movimiento movimiento);
        List<Movimiento> GetAllMovimientosFromDocumentoId(Documento documento);
        List<Movimiento> GetAllMovimientosFromDocumentoCodigo(Documento documento);
        List<Movimiento> GetAllMovimientosFromDepartamento(Departamento departamento);
        List<Movimiento> GetAllMovimientosFromFecha(DateTime fechaInicio, DateTime fechaFinal);
        Movimiento GetMovimiento(Documento documento);
    }
}