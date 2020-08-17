using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MindMatters.Service.Services;

namespace MindMatters.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    
    public class FacilityController : Controller
    {
        private readonly IFacilityService _facilityService;

        public FacilityController(IFacilityService facilityService)
        {
            _facilityService = facilityService;
        }
        
        [HttpGet]
        public async Task<IEnumerable<FacilityDto>> Get()
        {
            var results = await _facilityService.GetAllServicesAsync();
            return results;
        }
    }
}
