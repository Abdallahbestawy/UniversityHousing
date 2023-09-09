using Microsoft.EntityFrameworkCore;
using UniversityHousing.Models;
using UniversityHousing.View_Model;

namespace UniversityHousing.Service
{
    public class AdminRepository : IAdminRepository
    {
        HousingContext context;
        public AdminRepository(HousingContext _context)
        {
            context = _context;
        }
        public int Create(AdminVM admin)
        {
            var user = new User
            {
                FirstName = admin.FirstName,
                LastName = admin.LastName,
                Email = admin.Email,
                Phone = admin.Phone,
                NationalId = admin.NationalId,
                DateOfBirth = admin.DateOfBirth,
                Gender = admin.Gender
            };
            context.users.Add(user);
            context.SaveChanges();
            var newAdmin = new Admin
            {
                userId = user.userId
            };

            context.Admins.Add(newAdmin);
            int raw = context.SaveChanges();
            return raw;
        }

        public int Delete(int id)
        {
            var user = context.users.FirstOrDefault(u=>u.userId == id);
            context.users.Remove(user);
            var admin = context.Admins.FirstOrDefault(u=>u.userId == id);
            context.Admins.Remove(admin);
            int raw = context.SaveChanges();
            return raw;
        }

        public AdminVM Edit(int id)
        {
            AdminVM? admin = context.Admins.Where(a=>a.userId == id).Select(a=> new AdminVM
            {
                userId =a.User.userId,
                FirstName = a.User.FirstName,
                LastName = a.User.LastName,
                Email = a.User.Email,
                Phone = a.User.Phone,
                NationalId =a.User.NationalId,
                DateOfBirth = a.User.DateOfBirth,
                Gender = a.User.Gender
            }).FirstOrDefault();
            return admin;
        }

        public List<AdminListVM> GetAll()
        {
            List<AdminListVM> admins = context.Admins.Select(
                a => new AdminListVM
                {
                userId = a.userId,
                FirstName = a.User.FirstName,
                LastName = a.User.LastName,
                Email = a.User.Email,
                Phone = a.User.Phone,
                NationalId = a.User.NationalId,
                DateOfBirth = a.User.DateOfBirth,
                Gender = a.User.Gender
            }).ToList();
            return admins;
        }

        public AdminListVM GetById(int id)
        {
            var admin = context.Admins.Where(a=>a.userId == id).Select(a=> new AdminListVM
            {
                userId = a.userId,
                FirstName =a.User.FirstName,
                LastName =a.User.LastName,
                Email =a.User.Email,
                Phone = a.User.Phone,
                NationalId=a.User.NationalId,
                DateOfBirth=a.User.DateOfBirth,
                Gender = a.User.Gender
            }).FirstOrDefault();
            return admin;
        }

        public int Update(int id, AdminVM admin)
        {
            var oldadmin = context.Admins.Include(a => a.User).Where(s => s.userId == id).FirstOrDefault();

            if (oldadmin != null)
            {
                if (oldadmin.User != null)
                {
                    oldadmin.User.FirstName = admin.FirstName;
                    oldadmin.User.LastName = admin.LastName;
                    oldadmin.User.Email = admin.Email;
                    oldadmin.User.Gender = admin.Gender;
                    oldadmin.User.NationalId = admin.NationalId;
                    oldadmin.User.Phone = admin.Phone;
                    oldadmin.User.DateOfBirth = admin.DateOfBirth;
                }
                int raw = context.SaveChanges();
                return raw;
            }
            else
            {
                return 0;
            }
        }

    }
}
