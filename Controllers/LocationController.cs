using AgendaBack2023.Data;
using AgendaBack2023.Entities;
using AgendaBack2023.Models.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgendaBack2023.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly AgendaBackContext _context;
        private readonly IMapper _mapper;

        public LocationController(AgendaBackContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            try
            {
                var locations = await _context.Locations.ToListAsync();

                var LocationsDTO = _mapper.Map<IEnumerable <LocationDTO>>(locations);

                return Ok(locations);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]

        public async Task<IActionResult> Post(CreateAndUpdateLocationDTO locationDTO)
        {
            try
            {
                var location = _mapper.Map<Location>(locationDTO);

                _context.Add(location);
                await _context.SaveChangesAsync();

                var locationItemDTO = _mapper.Map<LocationDTO>(location);

                return Ok(locationItemDTO);
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    
                    string innerExceptionMessage = ex.InnerException.Message;
                    string innerExceptionStackTrace = ex.InnerException.StackTrace;
                }

                
                return BadRequest(ex.Message);
            }
        }

    }
}
