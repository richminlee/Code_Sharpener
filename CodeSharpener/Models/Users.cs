using System;
using System.Collections.Generic;

namespace CodeSharpener.Models
{
    public partial class Users
    {
        public Users()
        {
            Content = new HashSet<Content>();
            Solution = new HashSet<Solution>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Content> Content { get; set; }
        public virtual ICollection<Solution> Solution { get; set; }
    }
}
