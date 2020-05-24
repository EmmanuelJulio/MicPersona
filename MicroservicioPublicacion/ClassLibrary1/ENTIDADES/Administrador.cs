using System;
using System.Collections.Generic;
using System.Text;

namespace DOMINIO.ENTIDADES
{
    public class Administrador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Usuario { get; set; }
        public virtual Usuario UsuarioNavigator { get; set; }


    }
}
