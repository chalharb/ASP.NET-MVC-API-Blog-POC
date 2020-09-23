using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogPOC.Models
{
    public class Tag
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}