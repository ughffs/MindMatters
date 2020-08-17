using Microsoft.EntityFrameworkCore;
using MindMatters.DomainModel.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MindMatters.Repository.Services
{
    public class FacilityRepository : IFacilityRepository
    {
        private readonly DataContext _context;

        public FacilityRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Facility>> SelectAllServicesAsync()
        {
            return await _context.Facilities.ToListAsync();
        }
    }
}
