using CinemaManager.ApplicationLogic.Abstractions;
using CinemaManager.ApplicationLogic.DataModel;
using CinemaManager.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaManager.ApplicationLogic.Services
{
    public class AdminsService
    {
        private IAdminRepository adminRepository;
        private IFilmRepository filmRepository;

        public AdminsService(IAdminRepository adminRepository, IFilmRepository filmRepository)
        {
            this.adminRepository = adminRepository;
            this.filmRepository = filmRepository;
        }

        public Admin GetAdminByUserId(string userId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            var admin = adminRepository.GetAdminByUserId(userIdGuid);
            if (admin == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }

            return admin;
        }
        
        public IEnumerable<Film> GetAdminFilms(string userId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            return filmRepository.GetAll()
                            .Where(film => film.Admin != null && film.Admin.UserId == userIdGuid)
                            .AsEnumerable();
        }

        public void AddFilm(string userId, string filmName, string filmDescription, string filmGenre)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var admin = adminRepository.GetAdminByUserId(userIdGuid);
            if (admin == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }
            filmRepository.Add(new Film() { Id = Guid.NewGuid(), Admin = admin, FilmName = filmName, FilmDescription = filmDescription, FilmGenre = filmGenre});
        }
    }
}
