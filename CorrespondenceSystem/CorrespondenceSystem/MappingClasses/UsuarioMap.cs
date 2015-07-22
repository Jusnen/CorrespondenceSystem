using CorrespondenceSystem.DomainClasses;
using FluentNHibernate.Mapping;

namespace CorrespondenceSystem.MappingClasses
{
    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {
            Id(a => a.id).Column("idUsuario");
            Map(a => a.nombre).Not.Nullable();
            Map(a => a.correo).Not.Nullable();
            References(a => a.tipoUsuario).Column("idTipoUsuario").Not.Nullable();
            Map(a => a.fechaRegistro).Not.Nullable();
            Map(a => a.fechaModificacion);
            Map(a => a.usuarioCreacion).Not.Nullable();
            Map(a => a.usuarioModificacion);
            HasMany(a => a.Movimientos)
                .KeyColumn("idUsuario");
        }
    }
}