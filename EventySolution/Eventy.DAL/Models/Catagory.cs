using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventy.DAL.Models
{
    public class Catagory
    {
        public int Ìd { get; set; }
        public string Name { get; set; }

        public IEnumerable<EventyEvent> EventList { get; set; } = new HashSet<EventyEvent>();

    }
}
