﻿using CorrespondenceSystem.DomainClasses;
using FluentNHibernate.Mapping;

namespace CorrespondenceSystem.MappingClasses
{
    public class MovimientoMap : ClassMap<Movimiento>
    {
        public MovimientoMap()
        {
            Id(a => a.idMovimiento);
            Map(a => a.fecha).Not.Nullable();
            Map(a => a.fechaCreacion).Not.Nullable();
            Map(a => a.fechaModificacion).Not.Nullable();
            References(a => a.documento).Column("idDocumento").Not.Nullable();
            References(a => a.mensajero).Column("idMensajero");
            References(a => a.tipoMovimiento).Column("idTipoMovimiento").Not.Nullable();
            References(a => a.departamento).Column("idDepartamento").Not.Nullable();
            References(a => a.usuario).Column("idUsuario");
            Map(a => a.fechaCreacion).Not.Nullable();
            Map(a => a.fechaModificacion);
            Map(a => a.usuarioCreacion).Not.Nullable();
            Map(a => a.usuarioModificacion);
        }
    }
}