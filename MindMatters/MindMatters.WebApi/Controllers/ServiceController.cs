using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MindMatters.Service.Dto.ServiceDto;

namespace MindMatters.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ServiceController : Controller
    {
        [HttpGet("{id}")]
        public ServiceDto GetService(int id)
        {
            var dto = new ServiceDto()
            {
                ServiceID = 1,
                Name = "Some Service"
            };
            return dto;
        }
    }
}
