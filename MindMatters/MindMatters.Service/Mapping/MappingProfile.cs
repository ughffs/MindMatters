using AutoMapper;
using MindMatters.DomainModel.Services;
using MindMatters.Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MindMatters.Services.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Facility, FacilityDto>();

        }
    }
}
