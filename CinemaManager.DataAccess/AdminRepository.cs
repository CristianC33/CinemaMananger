using CinemaManager.ApplicationLogic.Abstractions;
using CinemaManager.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaManager.DataAccess
{
    public class AdminRepository : BaseRepository<Admin>, IAdminRepository
    {
        public AdminRepository(FilmManagerDbContext dbContext):base(dbContext)
        {
            
        }
        public Admin GetAdminByUserId(Guid userId)
        {
            return dbContext.Admins
                            .Where(admin => admin.UserId == userId)
                            .SingleOrDefault();
        }
    }
}
