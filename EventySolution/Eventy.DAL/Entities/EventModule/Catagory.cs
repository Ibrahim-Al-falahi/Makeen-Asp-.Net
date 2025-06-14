using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventy.DAL.Entities.EventModule
{
    public class Catagory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<EventyEvent> EventList { get; set; } = new HashSet<EventyEvent>();

    }
}
