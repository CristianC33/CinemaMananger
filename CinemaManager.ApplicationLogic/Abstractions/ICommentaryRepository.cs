using CinemaManager.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManager.ApplicationLogic.Abstractions
{
    public interface ICommentaryRepository : IRepository<Commentary>
    {
        IEnumerable<Commentary> GetCommentariesCreatedByUser(Guid Id);
    }
}
