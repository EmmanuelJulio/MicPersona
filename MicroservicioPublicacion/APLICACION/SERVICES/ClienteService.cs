using DOMINIO.COMANDOS;
using DOMINIO.DTOS;
using DOMINIO.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APLICACION.SERVICES
{
    public interface IClienteService
    {
        Cliente CreateCliente(ClienteDTOs cliente);
        ICollection<Cliente> GetCliente();
        bool DeleteCliente(ClienteDTOs cliente);
        bool UpdateCliente(ClienteDTOs cliente);
        Cliente GetId(int id);
    }
    public class ClienteService : IClienteService
    {
        private IGenericRepository _repository;

        public ClienteService(IGenericRepository repository)
        {
            _repository = repository;
        }

        public Cliente CreateCliente(ClienteDTOs cliente)
        {
            Usuario NavigatorUsuario = _repository.GetBy<Usuario>(cliente.Usuario);
            var entity = new Cliente()
            {
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Email = cliente.Email,
                Usuario = cliente.Usuario,
                UsuarioNavigator = NavigatorUsuario
            };
            _repository.Add<Cliente>(entity);
            return entity;
        }

        public bool DeleteCliente(ClienteDTOs cliente)
        {
             Usuario NavigatorUsuario = _repository.GetBy<Usuario>(cliente.Usuario);
            var entity = new Cliente()
            {
                Id = cliente.Id,
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Email = cliente.Email,
                Usuario = cliente.Usuario,
                UsuarioNavigator = NavigatorUsuario
            };
            return _repository.Delete<Cliente>(entity);
        }

        public ICollection<Cliente> GetCliente()
        {
            return _repository.GetALL<Cliente>().ToList();
        }

        public Cliente GetId(int id)
        {
            return _repository.GetBy<Cliente>(id);
        }

        public bool UpdateCliente(ClienteDTOs cliente)
        {
            Usuario NavigatorUsuario = _repository.GetBy<Usuario>(cliente.Usuario);
            var entity = new Cliente()
            {
                Id = cliente.Id,
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Email = cliente.Email,
                Usuario = cliente.Usuario,
                UsuarioNavigator = NavigatorUsuario
            };
            return _repository.Delete<Cliente>(entity);
        }
    }
}
