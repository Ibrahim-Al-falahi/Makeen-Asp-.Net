using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventy.DAL.Entities.EventModule;
using Eventy.DAL.Entities.UserModule;

namespace Eventy.DAL.Entities.VolunteerModule
{
    public class Application
    {
        public int Id { get; set; }
        public DateTimeOffset ApplicationDate { get; set; }= DateTimeOffset.Now;
        public ApplicationStatus Status { get; set; }
        public string MotivationStatement { get; set; }
        public string RelevantExperience { get; set; }
        public DateTimeOffset DecisionDate { get; set; }
        public string DecisionReason { get; set; }

        [ForeignKey(nameof(VolunteerId))]
        public virtual Volunteer Volunteer { get; set; }
        public int VolunteerId { get; set; }

        [ForeignKey(nameof(CommiteeId))]
        public virtual Commitee Commitee { get; set; }
        public int CommiteeId { get; set; }
    }
}
