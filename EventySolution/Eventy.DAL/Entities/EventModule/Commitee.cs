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
    public class Commitee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RequiredVolunteers { get; set; }
        public string RequiredSkills { get; set; }

        [ForeignKey(nameof(EventyEventId))]
        public virtual EventyEvent EventyEvent { get; set; }
        public int EventyEventId { get; set; }

        [ForeignKey(nameof(LeaderId))]
        public virtual Volunteer Volunteer { get; set; }
        public int LeaderId { get; set; }

        public virtual IEnumerable<Application> ApplicationList { get; set; } = new HashSet<Application>();
    }
}
