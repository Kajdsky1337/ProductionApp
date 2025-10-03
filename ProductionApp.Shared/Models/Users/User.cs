using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionApp.Shared.Models.Users
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } // Unique username for the user
        public string PasswordHash { get; set; } // Hashed password for security
        public string Email { get; set; } // User's email address
        public string Role { get; set; } // Role of the user (e.g., Admin, Operator, Manager)
        public DateTime CreatedAt { get; set; }  = DateTime.UtcNow; // Timestamp when the user was created

    }
}
