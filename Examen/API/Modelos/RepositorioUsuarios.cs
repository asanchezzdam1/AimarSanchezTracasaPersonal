using Entidades;
using Context;

namespace Modelos
{
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private readonly ContextoConversor _context;

        public RepositorioUsuarios(ContextoConversor context)
        {
            _context = context;
        }

        public async Task<Usuario> postUsuario(Usuario usuario)
        {

        }
        public async IEnumerable<UsuarioVerDto> getUsuarios()
        {

        }
        public async Task<Usuario> getUser(string id)
        {

        }
    }
}
