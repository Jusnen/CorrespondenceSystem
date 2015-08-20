using SistemaCorrespondencia.MVC.DomainClasses;
using FluentNHibernate.Mapping;

namespace SistemaCorrespondencia.MVC.MappingClasses
{
    public class DepartamentoMap : ClassMap<Departamento>
    {
        public DepartamentoMap()
        {
            Id(a => a.Id).Column("idDepartamento");
            Map(a => a.descripcion).Not.Nullable();
            References(a => a.tipoDepartamento).Column("idTipoDepartamento").Not.Nullable();
        }
    }
}