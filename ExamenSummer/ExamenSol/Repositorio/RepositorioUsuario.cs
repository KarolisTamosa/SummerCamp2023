using Context;
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

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(User nuevoUsuario)
        {
            try
            {
                _context.Users.Add(nuevoUsuario);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                throw new Exception("Error al agregar un usuario.", ex);
            }
        }

        public IEnumerable<user> GetUsers()
        {
            return _context.Users.ToList();
        }

        public user GetUserById(string id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        // Otros métodos de repositorio según tus necesidades
    }
}
}
