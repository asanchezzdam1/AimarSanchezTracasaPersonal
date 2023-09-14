using Entidades;

namespace Modelos
{
    public interface IRepositorioUsuarios
    {
        Task<Usuario> postUsuario(Usuario usuario);
        IEnumerable<UsuarioVerDto> getUsuarios();
    }
}