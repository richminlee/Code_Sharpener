using System;
using System.Collections.Generic;

namespace CodeSharpener.Models
{
    public partial class Solution
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? ChallengeId { get; set; }
        public int? UserId { get; set; }

        public virtual Challenge Challenge { get; set; }
        public virtual Users User { get; set; }
    }
}
