using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogPOC.Models
{
    public class Post
    {
        public Post()
        {
            Tags = new HashSet<Tag>();
        }

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public DateTime PubDate { get; set; }

        public DateTime ModDate { get; set; }
        
        public virtual ICollection<Tag> Tags { get; set; }
    }
}