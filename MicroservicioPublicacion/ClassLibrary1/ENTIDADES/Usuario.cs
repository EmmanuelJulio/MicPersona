using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DOMINIO.ENTIDADES
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string uid { get; set; }
        public string Nombre { get; set; }
        public string gmail  { get; set; }
        public virtual UsuarioRoles UserRole { get; set; }
    }
}
