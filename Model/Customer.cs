using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testCrm.API.Model
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }
        public string LastName { get; set; }
        public string UserPrincipalName { get; set; }
        public string Phone { get; set; }
        public string JobTitle { get; set; }
        public int CountryId { get; set; }
        public bool IsWorking { get; set; }
        public bool IsActive { get; set; }
        public DateTime Birthday { get; set; }
        public int ActiveDirectoryId { get; set; }



                  

    }
}
