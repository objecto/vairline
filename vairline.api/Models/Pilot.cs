using Microsoft.AspNetCore.Identity;

namespace vairline.api.Models
{
    public class Pilot
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string UserId { get; set; } // Foreign key to IdentityUser
        public IdentityUser User { get; set; } // Navigation property to the user
    }

}
