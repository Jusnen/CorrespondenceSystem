using SistemaCorrespondencia.MVC.DomainClasses;
using FluentNHibernate.Mapping;

namespace SistemaCorrespondencia.MVC.MappingClasses
{
    public class MensajeroMap : ClassMap<Mensajero>
    {
        public MensajeroMap()
        {
            Id(a => a.Id).Column("idMensajero");
            Map(a => a.descripcion).Not.Nullable();
        }
    }
}