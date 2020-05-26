using CinemaManager.ApplicationLogic.Abstractions;
using CinemaManager.ApplicationLogic.DataModel;
using CinemaManager.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static CinemaManager.ApplicationLogic.DataModel.Film;

namespace CinemaManager.ApplicationLogic.Services
{
    public class AdminService
    {
        private IAdminRepository adminRepository;
        private IFilmRepository filmRepository;

        public AdminService(IAdminRepository adminRepository, IFilmRepository filmRepository)
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

            var admin = adminRepository.GetAdminById(userIdGuid);
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
                            .Where(film => film.Admin != null && film.Admin.Id == userIdGuid)
                            .AsEnumerable();
        }

        public void AddFilm(string name, string description,
            DateTime releaseDate, int duration, string director, string image)
        {
           /* Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var admin = adminRepository.GetAdminById(userIdGuid);
            if (admin == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }*/
            filmRepository.Add(new Film() {Name = name, Description = description, 
            Director = director, Duration = duration, ReleaseDate = releaseDate, ImageByteArray = image});
        }
    }
}
