using System.Collections.Generic;
using SistemaCorrespondencia.MVC.DomainClasses;

namespace SistemaCorrespondencia.MVC.Interfaces
{
    public interface IServiceUsuario
    {
        List<Usuario> GetAllUsuarios();
        Usuario GetUsuario();
        void InsertUsuario();
    }
}