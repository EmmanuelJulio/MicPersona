using DOMINIO.ENTIDADES;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATOS
{
    public class Contexto :DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Administrador> Administrador{ get; set; }
        public DbSet<Cliente> Cliente { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

    }
}
