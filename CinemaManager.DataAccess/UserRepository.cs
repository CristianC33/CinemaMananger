using CinemaManager.ApplicationLogic.Abstractions;
using CinemaManager.ApplicationLogic.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaManager.DataAccess
{
    class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(CinemaManagerDbContext dbContext) : base(dbContext)
        {

        }

        public User GetUserByGuid(Guid userGuid)
        {
            User foundUser = dbContext.Users
                             .Include(user => user.Name)
                             .Where(user => user.Id == userGuid)
                             .SingleOrDefault();
            return foundUser;
        }

        public User GetUserById(Guid Id)
        {
            User foundUser = dbContext.Users
                             .Include(user => user.Name)
                             .Where(user => user.Id == Id)
                             .SingleOrDefault();
            return foundUser;
        }

    }
}
