using UniversityHousing.Models;

namespace UniversityHousing.Service
{
    public interface IAddressRepository
    {
        Address? GetAddressById(int id);
        
    }
}
