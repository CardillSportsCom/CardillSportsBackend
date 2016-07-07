using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalTask.Models
{

    public class User
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool deleted { get; set; }
        public DateTime DateCreated { get; set; }

    }
    public class UserJson
    {
        public UserJson()
        {

        }
        public UserJson(User u)
        {
            this.ID = u.ID;
            this.firstName = u.firstName;
            this.lastName = u.lastName;
            this.userName = u.userName;
            this.email = u.email;
            this.deleted = u.deleted;
            this.DateCreated = u.DateCreated;
        }
        public int ID;
        public string firstName;
        public string lastName;
        public string userName;
        public string email;
        public bool deleted;
        public DateTime DateCreated;
    }

}