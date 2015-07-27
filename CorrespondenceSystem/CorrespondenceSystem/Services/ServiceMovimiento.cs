using System;
using System.Collections.Generic;
using CorrespondenceSystem.DomainClasses;
using CorrespondenceSystem.Interfaces;

namespace CorrespondenceSystem.Services
{
    public class ServiceMovimiento : IServiceMovimiento
    {
        public void InsertMovimiento(Movimiento movimiento)
        {
            throw new NotImplementedException();
        }

        public List<Movimiento> GetAllMovimientosFromDocumentoId(Documento documento)
        {
            throw new NotImplementedException();
        }

        public List<Movimiento> GetAllMovimientosFromDocumentoCodigo(Documento documento)
        {
            throw new NotImplementedException();
        }

        public List<Movimiento> GetAllMovimientosFromDepartamento(Departamento departamento)
        {
            throw new NotImplementedException();
        }

        public List<Movimiento> GetAllMovimientosFromFecha(DateTime fechaInicio, DateTime fechaFinal)
        {
            throw new NotImplementedException();
        }

        public Movimiento GetMovimiento(Documento documento)
        {
            throw new NotImplementedException();
        }
    }
}