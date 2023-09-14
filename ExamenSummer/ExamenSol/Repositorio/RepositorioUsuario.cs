using Context;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private readonly ApplicationDbContext _context;

        public RepositorioUsuario(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<UsuarioVerDto> GetUsuarios()
        {
            var cutoffDate = DateTime.Now.AddYears(-21);

            var query = _context.usuarios
                .Where(u => u.FechaNacimiento < cutoffDate)
                .OrderByDescending(u => u.Nombre)
                .Select(u => new UsuarioVerDto
                {
                    Nombre = u.Nombre,
                    Telefono = u.Telefono,
                    FechaNacimiento = u.FechaNacimiento
                });

            return query.Take(10);
        }


        public async Task<Usuario> GetUsuario(string nombreUsuario)
        {
            var resultado = _context.usuarios.FirstOrDefault(m => m.Nombre == nombreUsuario);
            return resultado;

        }

        public async Task<Usuario> PostUsuario(Usuario usuario)
        {
            Usuario existeUsuario = _context.usuarios.FirstOrDefault(m => m.Id == usuario.Id);
            Usuario listaUsuario = new Usuario();
            if (existeUsuario == null)
            {
                listaUsuario.Id = Guid.NewGuid().ToString();
                listaUsuario.Nombre = usuario.Nombre;
                listaUsuario.Telefono = usuario.Telefono;
                listaUsuario.FechaNacimiento = usuario.FechaNacimiento;

                _context.Add(listaUsuario);
                _context.SaveChanges();
            }
            return usuario;
        }

    }
}
