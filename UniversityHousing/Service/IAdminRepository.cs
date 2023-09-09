using System.Runtime.InteropServices;
using UniversityHousing.View_Model;

namespace UniversityHousing.Service
{
    public interface IAdminRepository
    {
        int Create(AdminVM admin);
        List<AdminListVM> GetAll();
        AdminListVM GetById(int id);
        int Update(int id,AdminVM admin);
        AdminVM Edit(int id);
        int Delete(int id);
    }
}
