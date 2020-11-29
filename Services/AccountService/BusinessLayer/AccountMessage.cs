using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class AccountMessage
    {
        public string AccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Balance { get; set; }
        public DateTime DateRegistered { get; set; }
        public string Phone { get; set; }
        public string Credits { get; set; }
        public string Description { get; set; }
    }
}
