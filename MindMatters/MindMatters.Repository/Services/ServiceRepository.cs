using Microsoft.EntityFrameworkCore;
using MindMatters.DomainModel.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MindMatters.Repository.Services
{
    public class ServiceRepository
    {
        private readonly DataContext _context;

        public ServiceRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Service>> SelectAllServicesAsync()
        {
            return await _context.Services.ToListAsync();
        }
    }
}
