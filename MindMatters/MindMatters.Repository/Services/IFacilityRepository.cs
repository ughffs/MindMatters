using MindMatters.DomainModel.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MindMatters.Repository.Services
{
    public interface IFacilityRepository
    {
        Task<List<Facility>> SelectAllServicesAsync();
    }
}
