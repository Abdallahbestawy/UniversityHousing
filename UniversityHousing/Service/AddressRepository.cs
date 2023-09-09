using UniversityHousing.Models;

namespace UniversityHousing.Service
{
    public class AddressRepository : IAddressRepository
    {
        public readonly HousingContext context;
        public AddressRepository(HousingContext _context)
        {
            context = _context;
        }
        public Address? GetAddressById(int id)
        {
            var address = context.Addresses.FirstOrDefault(a => a.Id == id);
            return address == null ? null : address;
        }
    }
}
