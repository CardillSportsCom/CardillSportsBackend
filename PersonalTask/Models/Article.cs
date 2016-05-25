using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalTask.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageLink { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateDeleted { get; set; }
        public bool Deleted { get; set; }

        public virtual User Owner { get; set; }

    }
}