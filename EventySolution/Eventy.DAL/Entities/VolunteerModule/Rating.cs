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
    public class Rating
    {
        public int Id { get; set; }
        public int PunctualityRating { get; set; }
        public int QualityRating { get; set; }
        public int TeamworkRating { get; set; }
        public int InitiativeRating { get; set; }
        public int OverallRating { get; set; }
        public string Feedback { get; set; }
        public DateTimeOffset RatingDate { get; set; } = DateTimeOffset.Now;

        [ForeignKey(nameof(ApplicationUserId))]
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(EventyEventId))]
        public virtual EventyEvent EventyEvent { get; set; }
        public int EventyEventId { get; set; }

        [ForeignKey(nameof(VolunteerId))]
        public virtual Volunteer Volunteer { get; set; }
        public int VolunteerId { get; set; }

    }
}
