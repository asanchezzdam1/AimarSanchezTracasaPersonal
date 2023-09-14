using Entidades;

namespace Modelos
{
    public interface IRepositorioUsuarios
    {
        Task<Usuario> postUsuario(UsuarioAltaDto usuario);
        IEnumerable<UsuarioVerDto> getUsuarios();
    }
}