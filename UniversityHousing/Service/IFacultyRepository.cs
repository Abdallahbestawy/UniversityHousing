using UniversityHousing.Models;

namespace UniversityHousing.Service
{
    public interface IFacultyRepository
    {
        List<Faculty> GettAllFaculty();
        int CreateFaculty(Faculty faculty);
        int UpdateFaculty(int factId,Faculty faculty);
        int DeleteFaculty(int factId);
    }
}
