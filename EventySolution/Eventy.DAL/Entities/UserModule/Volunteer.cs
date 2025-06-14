using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventy.DAL.Entities.VolunteerModule;

namespace Eventy.DAL.Entities.UserModule
{
    public class Volunteer
    {
        public int Id { get; set; }
        public string EducationLevel { get; set; }
        public string FieldOfStudy { get; set; }
        public string Skills { get; set; }
        public string Interests { get; set; }
        public string PreviousExperience { get; set; }
        public int TotalEventsParticipated { get; set; }
        public decimal AverageRating { get; set; }
        public string VolunteerLevel { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual IEnumerable<Rating> RatingList { get; set; } = new HashSet<Rating>();
        public virtual IEnumerable<Application> ApplicationList { get; set; } = new HashSet<Application>();
    }
}
