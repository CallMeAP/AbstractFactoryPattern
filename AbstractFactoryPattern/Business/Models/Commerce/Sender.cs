using AbstractFactoryPattern.Business.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Business.Models.Commerce
{
    public class Sender
    {
        public string RecipientName { get; set; }
        public Country Country { get; set; }
        public string Street { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string PostalCode { get; set; }
    }
}
