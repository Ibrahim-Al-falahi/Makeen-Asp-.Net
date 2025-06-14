using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventy.DAL.Entities.EventModule
{
    public enum EventStatus
    {
        Draft,
        OpenForRegisteration,
        Registeration,
        Closed,
        Completed,
        Canceled
    }
}
