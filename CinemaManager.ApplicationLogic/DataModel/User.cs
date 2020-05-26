using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManager.ApplicationLogic.DataModel
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public static User CreateUser(string Name)
        {
            var newUser = new User()
            {
                Id = Guid.NewGuid(),
                Name = Name
            };
            return newUser;
        }
    }
}
