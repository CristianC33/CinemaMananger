using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManager.ApplicationLogic.DataModel
{
    public class Admin
    {
        public Guid AdminId { get; set; }
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Mobile { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
