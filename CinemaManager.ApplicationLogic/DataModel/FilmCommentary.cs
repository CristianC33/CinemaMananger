using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManager.ApplicationLogic.DataModel
{
    public class FilmCommentary
    {
        public Guid FilmComId { get; set; }
        public User User { get; set; }
        public Film Film { get; set; }
        public string Commentary { get; set; }
    }
}
