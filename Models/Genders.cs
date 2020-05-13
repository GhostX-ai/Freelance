using System;
using System.Collections.Generic;

namespace FreelanceV2.Models
{
    public partial class Genders
    {
        public Genders()
        {
            Accounts = new HashSet<Accounts>();
        }

        public int Id { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Accounts> Accounts { get; set; }
    }
}
