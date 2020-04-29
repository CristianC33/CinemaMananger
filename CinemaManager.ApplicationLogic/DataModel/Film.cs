using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManager.ApplicationLogic.DataModel
{
    public class Film
    {
        public Guid Id { get; set; }
        public string FilmName { get; set; }
        public string FilmDescription { get; set; }
        public string FilmGenre { get; set; }
        public Admin Admin {get; set;}
        public ICollection<User> Users { get; set; }
        public ICollection<FilmReview> FilmReviews { get; private set; }
        public ICollection<FilmCommentary> FilmCommentaries { get; private set; }
    }
}


