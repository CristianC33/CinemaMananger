using CinemaManager.ApplicationLogic.Abstractions;
using CinemaManager.ApplicationLogic.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManager.DataAccess
{
    public class CinemaManagerDbContext: DbContext
    {
        public CinemaManagerDbContext(DbContextOptions<CinemaManagerDbContext> options) : base(options)
        {
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Commentary> Commentaries { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
