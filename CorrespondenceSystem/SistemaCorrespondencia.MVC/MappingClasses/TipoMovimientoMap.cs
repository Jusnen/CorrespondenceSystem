using SistemaCorrespondencia.MVC.DomainClasses;
using FluentNHibernate.Mapping;

namespace SistemaCorrespondencia.MVC.MappingClasses
{
    public class TipoMovimientoMap : ClassMap<TipoMovimiento>
    {
        public TipoMovimientoMap()
        {
            Id(a => a.Id).Column("idTipoMovimiento");
            Map(a => a.descripcion).Not.Nullable();
        }
    }
}