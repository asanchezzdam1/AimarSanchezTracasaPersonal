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
        public IEnumerable<UsuarioVerDto> getUsuarios()
        {
            var fechaMayor21 = DateTime.Now;
            fechaMayor21 = fechaMayor21.AddYears(-21);

            var consultaLinq = from h in _context.usuarios
                        where h.fechaNacimiento < fechaMayor21
                        orderby h.nombre descending
                        select new UsuarioVerDto
                        {
                            nombre = h.nombre,
                            telefono = h.telefono,
                            fechaNacimiento = h.fechaNacimiento,
                        };
            return consultaLinq.Take(10);
        }
    }
}
