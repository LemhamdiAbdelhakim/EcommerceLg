using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace EcommerceLg.Models
{
    public class UserApplication : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageProfil { get; set; }
        public IList<Commande> commandes { get; set; }
        public IList<Review> reviews { get; set; }


    }
}
