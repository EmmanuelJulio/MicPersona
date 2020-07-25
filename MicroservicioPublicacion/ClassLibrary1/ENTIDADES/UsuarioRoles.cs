using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DOMINIO.ENTIDADES
{
   public  class UsuarioRoles
    {
        [Key]
        public int UsuarioId { get; set; }
        public int RoleId { get; set; }

        public virtual ICollection<Usuario> User { get; set; }
        public virtual ICollection<Role> Role { get; set; }
    }
}
