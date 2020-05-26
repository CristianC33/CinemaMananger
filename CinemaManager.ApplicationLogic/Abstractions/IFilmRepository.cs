using CinemaManager.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManager.ApplicationLogic.Abstractions
{
    public interface IFilmRepository: IRepository<Film>
    {
        Film GetFilmById(Guid Id);
    }
}
