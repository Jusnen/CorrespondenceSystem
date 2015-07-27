using System.Collections.Generic;
using CorrespondenceSystem.DomainClasses;

namespace CorrespondenceSystem.Interfaces
{
    public interface IServiceUsuario
    {
        List<Usuario> GetAllUsuarios();

        Usuario GetUsuario();

        void InsertUsuario();
    }
}