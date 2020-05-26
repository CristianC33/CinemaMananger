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
        public AdminRepository(CinemaManagerDbContext dbContext):base(dbContext)
        {
            
        }

        public Admin GetAdminById(Guid Id)
        {
            return dbContext.Admins
                            .Where(admin => admin.Id == Id)
                            .SingleOrDefault();
        }


    }
}
