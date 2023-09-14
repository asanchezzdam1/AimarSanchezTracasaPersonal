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

        public async Task<Usuario> postUsuario(Usuario usuario)
        {
            Usuario existeIdUsuario = context.usuarios.FirstOrDefault(m => m.id == usuario.id);
            Usuario listaUsuario = new Usuario();
            if (existeIdUsuario == null)
            {
                context.Add(usuario);
                context.SaveChanges();
            }
            return usuario;
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
