using AutoMapper;
using Entidades;

namespace API.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioVerDto, Usuario>();
        }
    }
}
