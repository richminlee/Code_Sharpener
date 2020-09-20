using System;
using System.Collections.Generic;

namespace CodeSharpener.Models
{
    public partial class Content
    {
        public Content()
        {
            Challenge = new HashSet<Challenge>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ConceptLink { get; set; }
        public string WalkthruLink { get; set; }
        public int? UserId { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<Challenge> Challenge { get; set; }
    }
}
