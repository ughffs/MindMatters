using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MindMatters.DomainModel.Services;
using MindMatters.Repository.Services;
using MindMatters.Service.Services;

namespace MindMatters.Services.Services
{
    public class FacilityService : IFacilityService
    {
        private readonly IFacilityRepository _facilityRepository;
        private readonly IMapper _mapper;

        public FacilityService (IFacilityRepository facilityRepository, IMapper mapper)
        {
            _facilityRepository = facilityRepository;
            _mapper = mapper;
        }

        public async Task<List<FacilityDto>> GetAllServicesAsync()
        {
            List<Facility> facilities = await _facilityRepository.SelectAllServicesAsync();
            var mappedResults = _mapper.Map<List<FacilityDto>>(facilities);

            return mappedResults;

        }
    }
}
