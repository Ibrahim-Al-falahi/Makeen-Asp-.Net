using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventy.DAL.Models
{
    public class EventyEvent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        [ForeignKey(nameof(CatagoryId))]
        public Catagory Catagory { get; set; }
        public int CatagoryId { get; set; }
    }
}
