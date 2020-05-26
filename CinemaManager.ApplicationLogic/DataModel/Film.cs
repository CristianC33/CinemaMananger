using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManager.ApplicationLogic.DataModel
{
    public class Film
    {
        public enum GenreCategory
        {
            Action,
            Adventure,
            Comedy,
            Crime,
            Drama,
            ScienceFiction
        }

        public enum LanguageCategory
        {
            English,
            Germany,
            French
        }

        public Guid Id { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public string ImageByteArray { get; set; }
        public int Duration { get; set; }

        public Admin Admin { get; set; }
        public ICollection<Review> FilmReviews { get; private set; }
        public ICollection<Commentary> FilmCommentaries { get; private set; }

    }
}


