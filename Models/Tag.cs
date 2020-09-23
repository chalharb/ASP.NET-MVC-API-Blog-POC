using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogPOC.Models
{
    public class Tag
    {
        public Tag()
        {
            Posts = new HashSet<Post>();
        }

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}