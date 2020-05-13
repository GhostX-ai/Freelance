using System;
using System.Collections.Generic;

namespace FreelanceV2.Models
{
    public partial class Rangs
    {
        public Rangs()
        {
            Accounts = new HashSet<Accounts>();
        }

        public int Id { get; set; }
        public string Rang { get; set; }
        public int MinSkillPoint { get; set; }

        public virtual ICollection<Accounts> Accounts { get; set; }
    }
}
