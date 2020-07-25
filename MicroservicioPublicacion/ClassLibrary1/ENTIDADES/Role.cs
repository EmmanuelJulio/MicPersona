using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DOMINIO.ENTIDADES
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string Name { get; set; }

        public virtual UsuarioRoles UserRole { get; set; }
    }
}
