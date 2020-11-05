using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Entities.User
{
    public class User: IdentityUser<int>
    {
        public User()
        {
            IsActive = true;
        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Route.Route> Routes { get; set; }
    }
    
    public enum GenderType
    {
        [Display(Name = "Male")]
        Male = 1,

        [Display(Name = "Female")]
        Female = 2
    }
}