using SistemaCorrespondencia.MVC.DomainClasses;
using FluentNHibernate.Mapping;

namespace SistemaCorrespondencia.MVC.MappingClasses
{
    public class DocumentoMap : ClassMap<Documento>
    {
        public DocumentoMap()
        {
            Id(a => a.Id).Column("idDocumento");
            Map(a => a.codigo).Not.Nullable();
            Map(a => a.fechaCreacionUsuario).Not.Nullable();
            Map(a => a.fechaRegistroUsuario).Not.Nullable();
            Map(a => a.asunto).Not.Nullable();
            References(a => a.departamento).Column("idDepartamento").Not.Nullable();
            Map(a => a.fechaCreacion).Not.Nullable();
            Map(a => a.fechaModificacion);
            Map(a => a.usuarioCreacion).Not.Nullable();
            Map(a => a.usuarioModificacion);
        }
    }
}