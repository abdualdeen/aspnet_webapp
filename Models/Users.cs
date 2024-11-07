using Microsoft.AspNetCore.Identity;

namespace aspnet_webapp.Models {
    public class Users : IdentityUser {
        public string FullName { get; set; }
    }
}