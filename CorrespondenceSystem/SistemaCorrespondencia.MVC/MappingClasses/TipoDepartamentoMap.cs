using SistemaCorrespondencia.MVC.DomainClasses;
using FluentNHibernate.Mapping;

namespace SistemaCorrespondencia.MVC.MappingClasses
{
    public class TipoDepartamentoMap : ClassMap<TipoDepartamento>
    {
        public TipoDepartamentoMap()
        {
            Id(a => a.Id).Column("idTipoDepartamento");
            Map(a => a.descripcion).Not.Nullable();
        }
    }
}