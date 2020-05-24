using System;
using System.Collections.Generic;
using System.Text;

namespace DOMINIO.ENTIDADES
{
    public  class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Email { get; set; }
        public int Usuario { get; set; }

        public virtual Usuario UsuarioNavigator { get; set; }

    }
}
