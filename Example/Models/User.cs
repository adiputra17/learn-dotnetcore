using System;
using System.ComponentModel.DataAnnotations;

namespace Example.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public long RoleId { get; set; }
        public string PhotoUrl { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastLogin { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastLogout { get; set; }
    }
}
