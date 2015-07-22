using CorrespondenceSystem.DomainClasses;
using FluentNHibernate.Mapping;

namespace CorrespondenceSystem.MappingClasses
{
    public class MensajeroMap : ClassMap<Mensajero>
    {
        public MensajeroMap()
        {
            Id(a => a.id).Column("idMensajero");
            Map(a => a.descripcion).Not.Nullable();
        }
    }
}