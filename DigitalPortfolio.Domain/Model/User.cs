using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPortfolio.Domain.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Description { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        public string ImageUrl { get; set; }

        public string PhoneNumber { get; set; }
        public int FollowersCount { get; set; }
        public int WorksCount { get; set; }
        public string City { get; set; }
        public string Company { get; set; }

        bool Status { get; set; }
    
        List<string> Links { get; set; }
        List<string> Skills { get; set; }

        private bool Admin { get; }
        public User(int id, string firstName, string secondName, string email, string pass) 
        {
            Id = id;
            FirstName = firstName;
            SecondName = secondName;
            Email = email;
            Password = pass;
        }

        public User() { }
    }
}
