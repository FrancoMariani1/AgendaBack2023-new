using AgendaBack2023.Data.Repository.Interfaces;
using AgendaBack2023.Entities;
using AgendaBack2023.Models.DTO;
using AutoMapper;

namespace AgendaBack2023.Data.Repository.Implementations
{
    public class LocationRepository : ILocationRepository
    {
        private AgendaBackContext _context;
        private readonly IMapper _mapper;

        public LocationRepository(AgendaBackContext context)
        {
            _context = context;
        }

        public List<Location> GetAll()
        {
            return _context.Locations.ToList();
        }

        public Location GetById(int locationId)
        {
            return _context.Locations.SingleOrDefault(u => u.id == locationId);
        }
        public void Create(CreateAndUpdateLocationDTO dto)
        {
            _context.Locations.Add(_mapper.Map<Location>(dto));
        }

        public void Update(CreateAndUpdateLocationDTO dto)
        {
            _context.Locations.Update(_mapper.Map<Location>(dto));
        }

        public void Delete(int id)
        {
            _context.Locations.Remove(_context.Locations.Single(c => c.id == id));
        }
    }
    
}
