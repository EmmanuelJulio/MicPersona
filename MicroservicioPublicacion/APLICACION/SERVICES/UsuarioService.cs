using DOMINIO.COMANDOS;
using DOMINIO.DTOS;
using DOMINIO.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APLICACION.SERVICES
{
    public interface IUsuarioService
    {
        //Usuario CreateUsuario(UsuarioDTOs usuario);
        //ICollection<Usuario> GetUsuario();
        //bool DeleteUsuario(UsuarioDTOs usuario);
        //bool UpdateUsuario(UsuarioDTOs usuario);
        //Usuario GetId(int id);
    }

    public class UsuarioService : IUsuarioService
    {
        //private readonly IGenericRepository _repository;

        //public UsuarioService(IGenericRepository repository)
        //{
        //    _repository = repository;
        //}

        //public Usuario CreateUsuario(UsuarioDTOs usuario)
        //{
        //    var entity = new Usuario()
        //    {
        //        Nombre = usuario.Nombre,
        //        Password = usuario.Password
        //    };
        //    _repository.Add<Usuario>(entity);
        //    return entity;
        //}

        //public bool DeleteUsuario(UsuarioDTOs usuario)
        //{
        //    var entity = new Usuario()
        //    {
        //        Id = usuario.Id,
        //        Nombre = usuario.Nombre,
        //        Password  = usuario.Password
        //    };
        //    return _repository.Delete<Usuario>(entity);
        //}

        //public Usuario GetId(int id)
        //{
        //    return _repository.GetBy<Usuario>(id);
        //}

        //public ICollection<Usuario> GetUsuario()
        //{
        //    return _repository.GetALL<Usuario>().ToList();
        //}

        //public bool UpdateUsuario(UsuarioDTOs usuario)
        //{
        //    var entity = new Usuario()
        //    {
        //        Id = usuario.Id,
        //        Nombre = usuario.Nombre,
        //        Password = usuario.Password
        //    };
        //    return _repository.Update<Usuario>(entity);
        //}
    }
}
