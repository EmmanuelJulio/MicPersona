using DOMINIO.ENTIDADES;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATOS
{
    public class Contexto :DbContext
    {
        public DbSet<UsuarioRoles> UserRole { get; set; }
        public DbSet<Role> role{ get; set; }
        public DbSet<Usuario> user { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
    
    }
}
