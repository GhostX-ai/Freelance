using System;
using System.Collections.Generic;

namespace FreelanceV2.Models
{
    public partial class Announcemants
    {
        public Announcemants()
        {
            Binds = new HashSet<Binds>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string FullDescription { get; set; }
        public int MinWage { get; set; }
        public int? MaxWage { get; set; }
        public int WageTypeId { get; set; }
        public string UserId { get; set; }
        public DateTime PublicDate { get; set; }
        public int? Deadline { get; set; }
        public string FilePath { get; set; }

        public virtual Accounts User { get; set; }
        public virtual WagesType WageType { get; set; }
        public virtual ICollection<Binds> Binds { get; set; }
    }
}
