using System;
using System.Collections.Generic;

using SistemaCorrespondencia.MVC.DomainClasses;
using FluentNHibernate.Mapping;


namespace SistemaCorrespondencia.MVC.MappingClasses
{
    class TipoEntradaMap : ClassMap<TipoEntrada>
    {
        public TipoEntradaMap()
        {
            Table("TipoEntrada");
            Schema("dbo");

            Id(x => x.codigo, "IdTipoEntrada").GeneratedBy.Identity();
            Map(x => x.NombreTipoEntrada, "Nombre");
        }

    }
}
