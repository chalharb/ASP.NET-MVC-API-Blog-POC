using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogPOC.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public DateTime PubDate { get; set; }

        public DateTime ModDate { get; set; }

    }
}