using System;
using System.Collections.Generic;

namespace FreelanceV2.Models
{
    public partial class Accounts
    {
        public Accounts()
        {
            Announcemants = new HashSet<Announcemants>();
            Binds = new HashSet<Binds>();
        }

        public string Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int RoleId { get; set; }
        public int GenderId { get; set; }
        public string PhotoPath { get; set; }
        public int SkillPoints { get; set; }
        public string Information { get; set; }
        public DateTime BirthDate { get; set; }
        public int RangId { get; set; }

        public virtual Genders Gender { get; set; }
        public virtual Rangs Rang { get; set; }
        public virtual Roles Role { get; set; }
        public virtual ICollection<Announcemants> Announcemants { get; set; }
        public virtual ICollection<Binds> Binds { get; set; }
    }
}
