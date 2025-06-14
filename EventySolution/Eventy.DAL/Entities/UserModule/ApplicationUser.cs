using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventy.DAL.Entities.EventModule;
using Eventy.DAL.Entities.VolunteerModule;
using Microsoft.AspNetCore.Identity;

namespace Eventy.DAL.Entities.UserModule
{
    public class ApplicationUser:IdentityUser
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset CreatedDate { get; set; }= DateTimeOffset.Now;
        public DateTimeOffset LastLoginDate { get; set; }

        public virtual IEnumerable<EventyEvent> EventList { get; set; }=new HashSet<EventyEvent>();
        public virtual IEnumerable<Rating> RatingList { get; set; } = new HashSet<Rating>();
    }
}
