using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RateLimitWebApplication.ViewModel
{
    public class CommentViewModel
    {
        public int CommentId { get; set; }
        public int ArticalId { get; set; }
        public string CommentDescription { get; set; }
        public int Rating { get; set; }
        public DateTime CommentOn { get; set; }
    }
}