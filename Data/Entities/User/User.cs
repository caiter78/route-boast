using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities.User
{
    public class User
    {
        public User()
        {
            IsActive = true;
        }

        [Required]
        [MinLength(2), MaxLength(50)]
        public string FirstName { get; set; }
        
        [Required]
        [MinLength(2), MaxLength(50)]
        public string LastName { get; set; }
        
        [Required]
        public GenderType Gender { get; set; }
        
        [Required]
        [Range(13, 120)]
        public int Age { get; set; }
        
        [Required]
        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

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