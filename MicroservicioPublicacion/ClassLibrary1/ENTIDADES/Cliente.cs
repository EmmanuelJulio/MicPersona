using System;
using System.Collections.Generic;
using System.Text;

namespace DOMINIO.ENTIDADES
{
    public  class Cliente
    {
        public int Id { get; set; }
        public string uid { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }

        public virtual ICollection<UsuarioRoles> UserRole { get; set; }

    }
}
