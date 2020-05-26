using CinemaManager.ApplicationLogic.Abstractions;
using CinemaManager.ApplicationLogic.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaManager.DataAccess
{
    class CommentaryRepository : BaseRepository<Commentary>, ICommentaryRepository
    {
        public CommentaryRepository(CinemaManagerDbContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<Commentary> GetCommentariesCreatedByUser(Guid Id)
        {
            return dbContext.Commentaries
                            .Include(Commentary => Commentary.Message)
                            .Where(Commentary => Commentary.UserId == Id)
                            .AsEnumerable();
        }
    }
}
