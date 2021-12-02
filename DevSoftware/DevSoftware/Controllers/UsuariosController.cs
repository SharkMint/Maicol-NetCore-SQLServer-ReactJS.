using DevSoftware.Context;
using DevSoftware.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DevSoftware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private AppDbContext context;

        public UsuariosController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Usuarios> Get()
        {
            return context.Usuarios.ToList();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Usuarios Get(int id)
        {
            var Usuarios = context.Usuarios.FirstOrDefault(p => p.Id == id);
            return Usuarios;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] Usuarios usuarios)
        {
            try
            {
            context.Usuarios.Add(usuarios);
            context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
            
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Usuarios usuarios)
        {
            if (usuarios.Id == id)
            {
                context.Entry(usuarios).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            } 
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var usuarios = context.Usuarios.FirstOrDefault(p => p.Id == id);
            if (usuarios != null)
            {
                context.Usuarios.Remove(usuarios);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
