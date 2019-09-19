using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testCrm.API.Model
{
    public class Ticket
    {
        public int Id { get; set; }
        public int RolId { get; set; }
        public int TicketTypeId { get; set; }
        public int TicketStateId { get; set; }
        public int PriorityId { get; set; }
        public int ContactId { get; set; }
        public int UserId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ModiﬁcationDate { get; set; }

         
    }
}
