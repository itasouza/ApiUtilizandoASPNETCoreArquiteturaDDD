using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Entities;
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

        //localhost:5000/api/usuario/46464646464
        [HttpGet]
        [Route("{id}", Name ="GetWithId")]
        public async Task<ActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);//400 bad request - solicitação inválida
            }

            try
            {
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }


        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UsuarioEntity user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);//400 bad request - solicitação inválida
            }

            try
            {
                var result = await _service.Post(user);
                if(result != null)
                {
                    return Created(new Uri (Url.Link("GetWithId", new { id = result.Id })),result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UsuarioEntity user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);//400 bad request - solicitação inválida
            }

            try
            {
                var result = await _service.Put(user);
                if (result != null)
                {
                    return Ok (result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete]
        [Route("{id}", Name = "GetWithId")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);//400 bad request - solicitação inválida
            }

            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}