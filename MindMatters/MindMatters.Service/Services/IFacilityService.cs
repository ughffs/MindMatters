using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MindMatters.DomainModel.Services;

namespace MindMatters.Service.Services
{
    public interface IFacilityService
    {
        Task<List<FacilityDto>> GetAllServicesAsync();
    }
}
