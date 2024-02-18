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
        internal string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }

        private bool Admin { get; }
        public User(int id, string name, string email, string pass) 
        {
            Id = id;
            Name = name;
            Email = email;
            Password = pass;
        }
    }
}
