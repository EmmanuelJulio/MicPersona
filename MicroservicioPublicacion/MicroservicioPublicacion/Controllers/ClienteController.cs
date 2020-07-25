using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APLICACION.SERVICES;
using DOMINIO.DTOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace MicroservicioPersona.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteService _service;

        public ClienteController(IClienteService service)
        {
            _service = service;
        }
        //[HttpPost]
        //public IActionResult Post(ClienteDTOs cliente)
        //{
        //    try
        //    {
        //        return new JsonResult(_service.CreateCliente(cliente)) { StatusCode = 201 };
        //    }
        //    catch (Exception e)
        //    {

        //        return BadRequest(e.Message);
        //    }
        //}
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    try
        //    {
        //        return new JsonResult(_service.GetCliente()) { StatusCode = 200 };
        //    }
        //    catch (Exception e)
        //    {

        //        return BadRequest(e.Message);
        //    }
        //}
        //[HttpDelete]
        //public IActionResult Delete(ClienteDTOs cliente)
        //{
        //    try
        //    {
        //        return new JsonResult(_service.DeleteCliente(cliente)) { StatusCode = 200 };
        //    }
        //    catch (Exception e)
        //    {

        //        return BadRequest(e.Message);
        //    }
        //}
        //[HttpPut]
        //public IActionResult Update(ClienteDTOs cliente)
        //{
        //    try
        //    {
        //        return new JsonResult(_service.UpdateCliente(cliente)) { StatusCode = 200 };
        //    }
        //    catch (Exception e)
        //    {

        //        return BadRequest(e.Message);
        //    }
        //}
        //[HttpGet("getID")]
        //public IActionResult getID([FromQuery]int id)
        //{
        //    try
        //    {
        //        return new JsonResult(_service.GetId(id)) { StatusCode = 200 };
        //    }
        //    catch (Exception e)
        //    {

        //        return BadRequest(e.Message);
        //    }
        //}
    }
}