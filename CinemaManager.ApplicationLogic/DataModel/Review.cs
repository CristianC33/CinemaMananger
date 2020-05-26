using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManager.ApplicationLogic.DataModel
{
    public class Review
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; } 
        public Guid FilmId { get; set; }
        public string Message { get; set; }
    }
}
