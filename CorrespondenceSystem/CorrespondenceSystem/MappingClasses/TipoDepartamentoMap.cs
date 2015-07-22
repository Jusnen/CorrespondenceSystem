using CorrespondenceSystem.DomainClasses;
using FluentNHibernate.Mapping;

namespace CorrespondenceSystem.MappingClasses
{
    public class TipoDepartamentoMap : ClassMap<TipoDepartamento>
    {
        public TipoDepartamentoMap()
        {
            Id(a => a.id).Column("idTipoDepartamento");
            Map(a => a.descripcion).Not.Nullable();
        }
    }
}