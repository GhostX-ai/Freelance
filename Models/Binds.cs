using System;
using System.Collections.Generic;

namespace FreelanceV2.Models
{
    public partial class Binds
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int AnnouncemantId { get; set; }

        public virtual Announcemants Announcemant { get; set; }
        public virtual Accounts User { get; set; }
    }
}
