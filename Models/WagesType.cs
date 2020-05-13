using System;
using System.Collections.Generic;

namespace FreelanceV2.Models
{
    public partial class WagesType
    {
        public WagesType()
        {
            Announcemants = new HashSet<Announcemants>();
        }

        public int Id { get; set; }
        public string WageType { get; set; }

        public virtual ICollection<Announcemants> Announcemants { get; set; }
    }
}
