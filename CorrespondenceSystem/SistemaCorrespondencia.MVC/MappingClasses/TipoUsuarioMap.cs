using SistemaCorrespondencia.MVC.DomainClasses;
using FluentNHibernate.Mapping;

namespace SistemaCorrespondencia.MVC.MappingClasses
{
    public class TipoUsuarioMap : ClassMap<TipoUsuario>
    {
        public TipoUsuarioMap()
        {
            Id(a => a.Id).Column("idTipoUsuario");
            Map(a => a.descripcion).Not.Nullable();
        }
    }
}