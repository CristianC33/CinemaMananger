using CinemaManager.ApplicationLogic.Abstractions;
using CinemaManager.ApplicationLogic.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaManager.DataAccess
{
    public class FilmRepository : BaseRepository<Film>, IFilmRepository
    {
        public FilmRepository(CinemaManagerDbContext dbContext) : base(dbContext)
        { 

        }

        public Film GetFilmById(Guid Id)
        {
            Film foundFilm = dbContext.Films
                             .Include(film => film.Name)
                             .Where(film => film.Id == Id)
                             .SingleOrDefault();
            return foundFilm;
        }

    }
}
