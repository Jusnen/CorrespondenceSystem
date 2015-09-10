using SistemaCorrespondencia.MVC.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCorrespondencia.MVC.DomainClasses
{
    public class TipoEntrada : Entity<int>
    {
       public virtual int codigo { get; set;}
       public virtual string NombreTipoEntrada { get; set; }

    }
}
