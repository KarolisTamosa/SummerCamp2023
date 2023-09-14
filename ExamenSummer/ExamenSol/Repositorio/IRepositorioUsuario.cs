using Models;

namespace Repositorio
{
    public interface IRepositorioUsuario
    {
        IEnumerable<UsuarioVerDto> GetUsuarios();
        Task<Usuario> GetUsuario(string nombreUsuario);
        Task<Usuario> PostUsuario(Usuario usuario);
    }
}