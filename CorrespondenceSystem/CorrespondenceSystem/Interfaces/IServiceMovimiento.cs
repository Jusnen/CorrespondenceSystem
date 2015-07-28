using System;
using System.Collections.Generic;
using CorrespondenceSystem.DomainClasses;

namespace CorrespondenceSystem.Interfaces
{
    public interface IServiceMovimiento
    {
        List<Movimiento> GetAllMovimientosFromDocumentoId(int idDocumento);
        List<Movimiento> GetAllMovimientosFromDocumentoCodigo(string codigoDocumento);
        List<Movimiento> GetAllMovimientosFromDepartamento(int idDepartamento);
        List<Movimiento> GetAllMovimientosFromFecha(int idDepartamento, DateTime fechaInicio, DateTime fechaFinal);
        
        Movimiento GetMovimiento(int idDocumento);

        void InsertMovimiento(Movimiento movimiento);
    }
}