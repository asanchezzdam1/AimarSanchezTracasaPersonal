using AutoMapper;

namespace API.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioVerDto, Usuario>();

            CreateMap<Usuario, UsuarioActualizarDto>();
        }
    }
}
