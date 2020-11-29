using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Models
{
    public class AccountResponse
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public AccountMessage Account { get; set; }
    }
}
