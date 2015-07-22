using CorrespondenceSystem.DomainClasses;
using FluentNHibernate.Mapping;

namespace CorrespondenceSystem.MappingClasses
{
    public class TipoUsuarioMap : ClassMap<TipoUsuario>
    {
        public TipoUsuarioMap()
        {
            Id(a => a.id).Column("idTipoUsuario");
            Map(a => a.descripcion).Not.Nullable();
        }
    }
}