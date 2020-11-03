using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeSharpener.Models
{
    public partial class Users
    {
        public Users()
        {
            Content = new HashSet<Content>();
            Solution = new HashSet<Solution>();
        }
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }
        [Required]
        [MinLength(2)]
        [Display(Name = "Middle Name:")]
        public string MiddleName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address:")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        [Display(Name = "Password:")]
        public string Password { get; set; }
        //[NotMapped]
        //[Compare("Password")]
        //[DataType(DataType.Password)]
        //public string Confirm { get; set; }

        public virtual ICollection<Content> Content { get; set; }
        public virtual ICollection<Solution> Solution { get; set; }
    }
}
