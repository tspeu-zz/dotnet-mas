using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testCrm.API.Model
{
    public class TaskTicket
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public int TicketId { get; set; }
        public int ActionTypeId { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsCompleted { get; set; }
        public int StateId { get; set; }
        public int QueueId { get; set; }
         

    }
}
