using AutoMapper;

namespace NZWalks.API.Profiles
{
    public class WalkDifficulty : Profile
    {
        public WalkDifficulty()
        {
            CreateMap<Models.Domain.WalkDifficulty, Models.DTO.WalkDifficulty>()
                .ReverseMap();
        }
    }
}
