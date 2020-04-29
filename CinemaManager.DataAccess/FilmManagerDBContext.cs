using CinemaManager.ApplicationLogic.Abstractions;
using CinemaManager.ApplicationLogic.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManager.DataAccess
{
    public class FilmManagerDbContext: DbContext
    {
        public FilmManagerDbContext(DbContextOptions<FilmManagerDbContext> options) : base(options)
        {
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<FilmReview> FilmReviews { get; set; }
        public DbSet<FilmCommentary> FilmCommentaries { get; set; }
    }
}
