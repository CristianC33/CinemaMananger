using CinemaManager.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManager.ApplicationLogic.Abstractions
{
    public interface IAdminRepository : IRepository<Admin>
    {
        Admin GetAdminById(Guid Id);
    }
}
