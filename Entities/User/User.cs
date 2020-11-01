using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Entities.Common;
using Microsoft.AspNetCore.Identity;

namespace Entities.User
{
    public class User: IdentityUser<int>, IEntity
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
        public ICollection<Route.Route> Routes { get; set; }
    }
    
    public enum GenderType
    {
        [Display(Name = "Male")]
        Male = 1,

        [Display(Name = "Female")]
        Female = 2
    }
}