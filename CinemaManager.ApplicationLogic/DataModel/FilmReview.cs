using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManager.ApplicationLogic.DataModel
{
    public class FilmReview
    {
        public Guid FilmRevId { get; set; }
        public User User { get; set; }
        public Film Film { get; set; }        
        public string Review { get; set; }
    }
}
