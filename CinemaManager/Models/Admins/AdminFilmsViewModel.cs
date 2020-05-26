using CinemaManager.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaManager.Models.Admins
{
    public class AdminFilmsViewModel
    {
        public Admin Admin { get; set; }
        public IEnumerable<Film> Film {get; set;}
    }
}
