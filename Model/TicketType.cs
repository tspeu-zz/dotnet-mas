using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testCrm.API.Model
{
    public class TicketType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAutomaticAssignation { get; set; }


    }
}
