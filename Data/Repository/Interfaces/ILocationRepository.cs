using AgendaBack2023.Entities;
using AgendaBack2023.Models.DTO;

namespace AgendaBack2023.Data.Repository.Interfaces
{
    public interface ILocationRepository
    {
        List<Location> GetAll();
        void Create(CreateAndUpdateLocationDTO dto);
        void Update(CreateAndUpdateLocationDTO dto);
        void Delete(int id);
    }
}
