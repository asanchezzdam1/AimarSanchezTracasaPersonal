using AutoMapper;
using Entidades;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace API.Controllers
{
    public class UsuariosController
    {
        [Route("api/usuarios")]
        [ApiController]
        public class UsuariosControllerAPI : ControllerBase
        {
            private readonly IRepositorioUsuarios repositorioUsuarios;
            private readonly IMapper mapper;

            public UsuariosControllerAPI(IRepositorioUsuarios repositorioUsuarios, IMapper mapper)
            {
                this.repositorioUsuarios = repositorioUsuarios;
                this.mapper = mapper;
            }

            [HttpGet]
            public async Task<ActionResult<List<UsuarioVerDto>>> ObtenerUsuarios()
            {
                var usuarios = repositorioUsuarios.getUsuarios();
                if (usuarios == null) return NotFound();
                return Ok(usuarios);
            }

            [HttpPost]
            [Route("registro")]
            public async Task<ActionResult<UsuarioVerDto>> registro([FromBody] UsuarioAltaDto registro)
            {
                Usuario usuarioAlta = new()
                {
                    id = Guid.NewGuid().ToString(),
                    nombre = registro.nombre,
                    telefono = registro.telefono,
                    fechaNacimiento = registro.fechaNacimiento
                };
                var usuario = await repositorioUsuarios.postUsuario(usuarioAlta);

                var usuarioVer = mapper.Map<UsuarioVerDto>(usuario);

                return Ok(usuarioVer);
            }
        }
    }
}