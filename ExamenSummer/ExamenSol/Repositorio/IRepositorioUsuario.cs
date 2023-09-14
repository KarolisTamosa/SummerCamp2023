using Models;

namespace Repositorio
{
    public interface IRepositorioUsuario
    {
        IEnumerable<Usuario> GetUsuarios();
        Task<Usuario> GetUsuario(string nombreUsuario);
        Task<Usuario> PostUsuario(Usuario usuario);
    }
}