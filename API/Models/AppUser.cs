using System;

namespace API.Models
{
    public class AppUser
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public required string UserName { get; set; }
        public required string Email { get; set; }

        // Additional properties can be added as needed
    }
}