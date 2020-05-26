using CinemaManager.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;
namespace CinemaManager.ApplicationLogic.Abstractions
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserById(Guid Id);
        User GetUserByGuid(Guid userGuid);
    }
}
