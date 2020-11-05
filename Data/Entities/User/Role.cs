using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Data.Entities.User
{
    public class Role: IdentityRole<int>
    {
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
    }
}