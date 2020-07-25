using DOMINIO.COMANDOS;
using DOMINIO.DTOS;
using DOMINIO.QUERYS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICACION.SERVICES
{   
    
    public interface IAutenticacionServices
    {
        Task<FirebaseAdmin.Auth.UserRecord> crearUsuario(UserDTOs usuario);
        Task<ClienteCarritoDTOs> getCarrito(string uids);
        Task<int> Get(int cliente);
    }
    public class AutenticacionServices : IAutenticacionServices
    {
        private readonly IGenericRepository repository;
        private readonly IAutenticacionQuery query;

        public AutenticacionServices(IGenericRepository repository, IAutenticacionQuery query)
        {
            this.repository = repository;
            this.query = query;
        }

        public  Task<FirebaseAdmin.Auth.UserRecord> crearUsuario(UserDTOs usuario)
        {
           return query.crearUsuario(usuario);
        }

        public Task<int> Get(int cliente)
        {
            return query.Get(cliente);
        }

        public Task<ClienteCarritoDTOs>  getCarrito(string uids)
        {
            return query.getCarrito(uids);
        }
    }
}
