using AutoMapper;
using SimpleApi.Dtos.Character;
using SimpleApi.Models;

namespace SimpleApi
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}