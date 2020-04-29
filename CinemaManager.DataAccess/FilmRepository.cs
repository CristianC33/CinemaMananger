using CinemaManager.ApplicationLogic.Abstractions;
using CinemaManager.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaManager.DataAccess
{
    public class FilmRepository : BaseRepository<Film>, IFilmRepository
    {
        public FilmRepository(FilmManagerDbContext dbContext) : base(dbContext)
        { 
        }
    }
}
