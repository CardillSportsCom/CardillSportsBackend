using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalTask.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public bool deleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime? DateDeadline { get; set; }
        public virtual User user { get; set; }
        public virtual List<TaskEntry> taskEntries {get;set;}
    }
    public class TaskEntry
    {
        public int ID { get; set; }
        public string description { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual Task task { get; set; }

    }
}