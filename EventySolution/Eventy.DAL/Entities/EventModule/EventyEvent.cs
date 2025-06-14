using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventy.DAL.Entities.UserModule;
using Eventy.DAL.Entities.VolunteerModule;

namespace Eventy.DAL.Entities.EventModule
{
    public class EventyEvent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public DateTimeOffset RegisterationDeadline { get; set; }
        public EventStatus Status { get; set; }
        public DateTimeOffset CreatedDate { get; set; }= DateTimeOffset.Now;
        public DateTimeOffset UpdatedDate { get; set; }

        [ForeignKey(nameof(CatagoryId))]
        public virtual Catagory Catagory { get; set; }
        public int CatagoryId { get; set; }

        [ForeignKey(nameof(CreatorId))]
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string CreatorId { get; set; }

        public virtual IEnumerable<Rating> RatingList { get; set; } = new HashSet<Rating>();
        public virtual IEnumerable<Commitee> CommiteeList { get; set; } = new HashSet<Commitee>();
    }
}
