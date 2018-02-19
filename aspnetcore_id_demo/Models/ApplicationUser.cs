using Microsoft.AspNetCore.Identity;

namespace aspnetcore_id_demo.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}