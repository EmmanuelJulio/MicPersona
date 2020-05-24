using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APLICACION.SERVICES;
using DOMINIO.DTOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicioPersona.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministradorController : ControllerBase
    {
        private readonly IAdministradorService _service;

        public AdministradorController(IAdministradorService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult Post(AdministradorDTOs administrador)
        {
            try
            {
                return new JsonResult(_service.CreateAdministrador(administrador)) { StatusCode = 201 };
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return new JsonResult(_service.GetAdministrador()) { StatusCode = 200 };
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpDelete]
        public IActionResult Delete(AdministradorDTOs admin)
        {
            try
            {
                return new JsonResult(_service.DeleteAdmin(admin)) { StatusCode = 200 };
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public IActionResult Update(AdministradorDTOs admin)
        {
            try
            {
                return new JsonResult(_service.UpdateAdmin(admin)) { StatusCode = 200 };
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("getID")]
        public IActionResult getID([FromQuery]int id)
        {
            try
            {
                return new JsonResult(_service.GetId(id)) { StatusCode = 200 };
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}