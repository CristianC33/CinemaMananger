using CinemaManager.ApplicationLogic.Abstractions;
using CinemaManager.ApplicationLogic.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaManager.DataAccess
{
    class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(CinemaManagerDbContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<Review> GetReviewsCreatedByUser(Guid Id)
        {
            return dbContext.Reviews
                            .Include(Review => Review.Message)
                            .Where(Review => Review.UserId == Id)
                            .AsEnumerable();
        }
    }
}
