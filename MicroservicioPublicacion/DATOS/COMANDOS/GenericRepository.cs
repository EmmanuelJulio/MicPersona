using DOMINIO.COMANDOS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DATOS.COMANDOS
{
    public class GenericRepository : IGenericRepository
    {
        private readonly Contexto _context;

        public GenericRepository(Contexto dbcontex)
        {
            _context = dbcontex;

        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public bool Delete<T>(T entity) where T : class
        {
            if(entity != null )
            {
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            

        }

        public IEnumerable<T> GetALL<T>() where T : class
        {
            DbSet<T> table = null;
            table = _context.Set<T>();
            return table.ToList();

        }

        public T GetBy<T>(int id) where T : class
        {
            DbSet<T> table = _context.Set<T>();
            return table.Find(id);
        }


        public bool Update<T>(T entity) where T : class
        {
            if(entity != null)
            {
                _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
