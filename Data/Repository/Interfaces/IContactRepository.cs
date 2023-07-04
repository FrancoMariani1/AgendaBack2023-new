using AgendaBack2023.Entities;
using AgendaBack2023.Models.DTO;

namespace AgendaBack2023.Data.Repository.Interfaces
{
    public interface IContactRepository
    {
        public List<Contact> GetAllByUser(int id);
        public Contact Create(CreateAndUpdateContactDTO dto, int id);
        //public Contact Update(CreateAndUpdateContactDTO dto);
        public Contact Update(CreateAndUpdateContactDTO dto);
        public void Delete(int id);
        public Contact GetContactById(int id);

    }
}
