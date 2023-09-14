using Microsoft.AspNetCore.Mvc;
using Models;
using Repositorio;

namespace Examen.Controllers
{

    [Route("api")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IRepositorioUsuario repositorioUsuarios;

        public UsuariosController(IRepositorioUsuario repositorioUsuarios)
        {
            this.repositorioUsuarios = repositorioUsuarios;
        }

        [HttpGet]
        [Route("usuarios")]
        public async Task<ActionResult<List<Usuario>>> GetUsuarios()
        {
            var listaUsuarios = repositorioUsuarios.GetUsuarios();

            if (listaUsuarios == null) { return NotFound(); }

            return Ok(listaUsuarios);
        }

        [HttpPost]
        [Route("registro")]
        public async Task<IActionResult> PostUsuarios([FromBody] Usuario nuevoUsuario)
        {
            var userExists = await repositorioUsuarios.GetUsuario(nuevoUsuario.Nombre);

            Usuario userAlta = new()
            {
                Id = Guid.NewGuid().ToString(),
                Nombre = nuevoUsuario.Nombre,
                Telefono = nuevoUsuario.Telefono,
                FechaNacimiento = nuevoUsuario.FechaNacimiento
            };

            var usuario = await repositorioUsuarios.PostUsuario(userAlta);

            return Ok(nuevoUsuario);
        }
    }
}

