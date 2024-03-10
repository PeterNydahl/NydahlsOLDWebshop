using Microsoft.AspNetCore.Identity;
using NydahlsWebshop1000.Models;

namespace NydahlsWebshop1000.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
    }

}
