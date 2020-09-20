using System;
using System.Collections.Generic;

namespace CodeSharpener.Models
{
    public partial class Challenge
    {
        public Challenge()
        {
            Solution = new HashSet<Solution>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? ContentId { get; set; }

        public virtual Content Content { get; set; }
        public virtual ICollection<Solution> Solution { get; set; }
    }
}
