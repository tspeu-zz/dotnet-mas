using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testCrm.API.Model
{
    public class ContactData
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public int Country { get; set; }
        public string DNI { get; set; }
        public string Mail { get; set; }
        public bool IsDataValidated { get; set; }
        public int ContactTypeId { get; set; }

    }
}
