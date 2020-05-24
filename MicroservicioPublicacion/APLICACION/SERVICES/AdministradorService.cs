using DOMINIO.COMANDOS;
using DOMINIO.DTOS;
using DOMINIO.ENTIDADES;
using System.Collections.Generic;
using System.Linq;

namespace APLICACION.SERVICES
{
    public interface IAdministradorService
    {
        Administrador CreateAdministrador(AdministradorDTOs administrador);
        ICollection<Administrador> GetAdministrador();
        bool DeleteAdmin(AdministradorDTOs admin);
        bool UpdateAdmin(AdministradorDTOs admin);
        Administrador GetId(int id);
    }
    public   class AdministradorService : IAdministradorService
    {
        private readonly IGenericRepository _repository;

        public AdministradorService(IGenericRepository repository)
        {
            _repository = repository;
        }

        public Administrador CreateAdministrador(AdministradorDTOs administrador)
        {

            Usuario NavigatorUsuario = _repository.GetBy<Usuario>(administrador.Usuario);
            var entity = new Administrador()
            {
                Nombre = administrador.Nombre,
                Usuario = administrador.Usuario,
                UsuarioNavigator = NavigatorUsuario

            };
            _repository.Add<Administrador>(entity);
            return entity;
        }

        public bool DeleteAdmin(AdministradorDTOs admin)
        {
            Usuario NavigatorUsuario = _repository.GetBy<Usuario>(admin.Usuario);
            var entity = new Administrador()
            {
                Id = admin.Id,
                Nombre = admin.Nombre,
                Usuario= admin.Usuario,
                UsuarioNavigator = NavigatorUsuario
            };
            return _repository.Delete<Administrador>(entity);

        }

        public ICollection<Administrador> GetAdministrador()
        {
            return _repository.GetALL<Administrador>().ToList();
        }

        public Administrador GetId(int id)
        {
            return _repository.GetBy<Administrador>(id);
        }

        public bool UpdateAdmin(AdministradorDTOs admin)
        {
            Usuario NavigatorUsuario = _repository.GetBy<Usuario>(admin.Usuario);
            var entity = new Administrador()
            {
                Id = admin.Id,
                Nombre = admin.Nombre,
                Usuario = admin.Usuario,
                UsuarioNavigator = NavigatorUsuario
            };
            return _repository.Update<Administrador>(entity); 
        }
    }
}
