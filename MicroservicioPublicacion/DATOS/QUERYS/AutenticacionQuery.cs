using APLICACION.SERVICES;
using DOMINIO.DTOS;
using DOMINIO.ENTIDADES;
using DOMINIO.QUERYS;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using DOMINIO.COMANDOS;
using System.Runtime.InteropServices;
using System.Net.Http;
using Newtonsoft.Json;

namespace DATOS.QUERYS
{
    public class AutenticacionQuery : IAutenticacionQuery
    {
        private readonly Contexto context;
        private readonly IGenericRepository _repository;

        public AutenticacionQuery(Contexto context, IGenericRepository repository)
        {
            this.context = context;
            _repository = repository;
        }

        public async Task<FirebaseAdmin.Auth.UserRecord> crearUsuario(UserDTOs usuario)
        {
          
            //Crear un nuevo usuario para firebas -------->
            UserRecordArgs NewUser = new UserRecordArgs()
            {
                Email = usuario.Email,
                EmailVerified = false,
                PhoneNumber = usuario.Telefono,
                Password = usuario.Password,
                DisplayName = usuario.Nombre,
                PhotoUrl = "http://www.example.com/12345678/photo.png",
                Disabled = false,
            };
            UserRecord userRecord = await FirebaseAuth.DefaultInstance.CreateUserAsync(NewUser);
            //Creo un nuevo usuario para mi database local ------>
         
            return userRecord;
        }

        public async Task<ClienteCarritoDTOs> getCarrito(string uids)
        {
            ClienteCarritoDTOs clientecarrito = new ClienteCarritoDTOs();
            HttpClient http = new HttpClient();
            //Inicializo la app de firebase aca 
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile(@"D:\Datos Matias\firebase\Private Key\usuario-5093e-firebase-adminsdk-43fcf-1bf89503c6.json"),
            });
            var result = await FirebaseAuth.DefaultInstance.GetUserAsync(uids);
            var ExisteCliente = (from x in context.user where x.uid == uids select x.Id).FirstOrDefault<int>();
            if( ExisteCliente == 0)
            {
                var enityClient = new Usuario()
                {
                    uid = uids,
                    Nombre = result.DisplayName,
                    gmail = result.Email

                };
                _repository.Add<Usuario>(enityClient);
                var userrol = new UsuarioRoles()
                {
                    RoleId = 2,
                    UsuarioId = ExisteCliente 
                };
                _repository.Add<UsuarioRoles>(userrol);
                ExisteCliente = (from x in context.user where x.uid == uids select x.Id).FirstOrDefault<int>();

                string url = " https://localhost:44310/api/Carrito/VerificarClienteCarrito?clienteID=" + ExisteCliente;
                string request = await http.GetStringAsync(url);
                int gets = JsonConvert.DeserializeObject<int>(request);
                clientecarrito.CarritoId = gets;
                clientecarrito.ClienteId = ExisteCliente;
                clientecarrito.RolId = 2;

            }
            else
            {

                string url = " https://localhost:44310/api/Carrito/VerificarClienteCarrito?clienteID=" + ExisteCliente;
                string request = await http.GetStringAsync(url);
                int gets = JsonConvert.DeserializeObject<int>(request);
                clientecarrito.CarritoId = gets;
                clientecarrito.ClienteId = ExisteCliente;
                clientecarrito.RolId = 2;
            }
            
            return clientecarrito;
           
        }
        public async Task<int> Get(int cliente)
        {
            string url = " https://localhost:44310/api/Carrito/VerificarClienteCarrito?clienteID=" + cliente;
            using ( var http =  new HttpClient())
            {
                string request = await http.GetStringAsync(url);
                int gets = JsonConvert.DeserializeObject<int>(request);
                return gets;
            }
        }
    }
}
