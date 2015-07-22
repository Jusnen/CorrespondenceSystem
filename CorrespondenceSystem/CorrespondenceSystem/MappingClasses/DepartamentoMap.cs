using CorrespondenceSystem.DomainClasses;
using FluentNHibernate.Mapping;

namespace CorrespondenceSystem.MappingClasses
{
    public class DepartamentoMap : ClassMap<Departamento>
    {
        public DepartamentoMap()
        {
            Id(a => a.id).Column("idDepartamento");
            Map(a => a.descripcion).Not.Nullable();
            References(a => a.tipoDepartamento).Column("idTipoDepartamento").Not.Nullable();
        }
    }
}