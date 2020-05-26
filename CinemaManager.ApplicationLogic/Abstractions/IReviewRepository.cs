using CinemaManager.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManager.ApplicationLogic.Abstractions
{
    public interface IReviewRepository : IRepository<Review>
    {
        IEnumerable<Review> GetReviewsCreatedByUser(Guid Id);
    }
}
