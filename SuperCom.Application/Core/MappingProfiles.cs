using AutoMapper;
using SuperCom.Domain;

namespace SuperCom.Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Ticket, Ticket>();
        }
    }
}