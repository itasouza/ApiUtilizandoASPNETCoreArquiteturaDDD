using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Interfaces.Services.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }


        // GET api/values
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);//400 bad request - solicitação inválida
            }

            try
            {
                return Ok (await _service.GetAll());
            }
            catch (ArgumentException e)      
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }


    }
}