using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _9_Newspaper1.Models
{
    public class News
    {
        public News()
        {
            Post = new HashSet<Post>();
        }

        public int NewsId { get; set; }
        public string Sections { get; set; }

        public virtual ICollection<Post> Post { get; set; }

    }
}
