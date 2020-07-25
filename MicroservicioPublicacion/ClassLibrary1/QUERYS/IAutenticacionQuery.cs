using DOMINIO.DTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO.QUERYS
{
    public  interface IAutenticacionQuery
    {
         Task<FirebaseAdmin.Auth.UserRecord> crearUsuario(UserDTOs usuario);
            Task<ClienteCarritoDTOs> getCarrito(string uids);
        Task<int> Get(int cliente);
    }
}
