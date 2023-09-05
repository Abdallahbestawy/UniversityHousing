using UniversityHousing.Models;

namespace UniversityHousing.Service
{
    public class FacultyRepository : IFacultyRepository
    {
        private readonly HousingContext context;

        public FacultyRepository(HousingContext _context)
        {
            context = _context;
        }
        public int CreateFaculty(Faculty faculty)
        {
            context.Facultys.Add(faculty);
            int raw = context.SaveChanges();
            return raw;
        }

        public int DeleteFaculty(int factId)
        {
            var faculty = context.Facultys.FirstOrDefault(f => f.FacultyId == factId);
            context.Facultys.Remove(faculty);
            int raw=context.SaveChanges();
            return raw;
        }

        public List<Faculty> GettAllFaculty()
        {
            return context.Facultys.ToList();
        }

        public int UpdateFaculty(int factId, Faculty faculty)
        {
            throw new NotImplementedException();
        }
    }
}
