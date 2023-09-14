using Entidades;
using Context;

namespace Modelos
{
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private readonly ContextoConversor context;

        public RepositorioUsuarios(ContextoConversor context)
        {
            this.context = context;
        }

        public async Task<Usuario> postUsuario(UsuarioAltaDto usuario)
        {
            Usuario usuarioAlta = new()
            {
                id = Guid.NewGuid().ToString(),
                nombre = usuario.nombre,
                telefono = usuario.telefono,
                fechaNacimiento = usuario.fechaNacimiento
            };
            var existeIdUsuario = context.usuarios.FirstOrDefault(m => m.id == usuarioAlta.id);
            if (existeIdUsuario == null)
            {
                context.Add(usuarioAlta);
                await context.SaveChangesAsync();
            }
            return usuarioAlta;
        }
        public IEnumerable<UsuarioVerDto> getUsuarios()
        {
            var fechaMayor21 = DateTime.Now;
            fechaMayor21 = fechaMayor21.AddYears(-21);
            var consultaLinq = from h in context.usuarios
                        where h.fechaNacimiento <= fechaMayor21
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
