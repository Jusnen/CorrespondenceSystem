using System;
using System.Collections.Generic;
using System.Linq;
using CorrespondenceSystem.DomainClasses;
using CorrespondenceSystem.Interfaces;
using CorrespondenceSystem.Repositories;
using MvcGCP.NHibernateHelpers;
using NHibernate;

namespace CorrespondenceSystem.Services
{
    public class ServiceMovimiento : IServiceMovimiento
    {
        private readonly IRepository<Movimiento, int> _movimientoRepository;

        public ServiceMovimiento(IRepository<Movimiento, int> movimientoRepository)
        {
            _movimientoRepository = movimientoRepository;
        }

        public List<Movimiento> GetAllMovimientosFromDocumentoId(int idDocumento)
        {
            return _movimientoRepository.GetAll(x => x.documento.id == idDocumento).ToList();
        }

        public List<Movimiento> GetAllMovimientosFromDocumentoCodigo(string codigoDocumento)
        {
            return _movimientoRepository.GetAll(x => x.documento.codigo == codigoDocumento).ToList();
        }

        public List<Movimiento> GetAllMovimientosFromDepartamento(int idDepartamento)
        {
            return _movimientoRepository.GetAll(x => x.departamento.id == idDepartamento).ToList();
        }

        public List<Movimiento> GetAllMovimientosFromFecha(int idDepartamento, DateTime fechaInicio, DateTime fechaFinal)
        {
            return _movimientoRepository.GetAll(x => x.departamento.id == idDepartamento &&
                                           x.fecha >= fechaInicio &&
                                           x.fecha <= fechaFinal)
                .ToList();
        }

        public Movimiento GetMovimiento(int idDocumento)
        {
            return _movimientoRepository.Get(x => x.documento.id == idDocumento);
        }

        public void InsertMovimiento(Movimiento movimiento)
        {
            _movimientoRepository.Insert(movimiento);
        }
    }
}