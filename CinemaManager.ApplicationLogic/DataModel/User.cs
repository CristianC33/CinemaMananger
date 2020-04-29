using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManager.ApplicationLogic.DataModel
{
    public class User
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
