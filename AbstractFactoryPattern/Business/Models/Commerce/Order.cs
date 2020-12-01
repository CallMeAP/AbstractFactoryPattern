using AbstractFactoryPattern.Business.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Business.Models.Commerce
{
    public class Order
    {
        public Order(Sender sender)
        {
            Sender = sender;
        }

        public string Description { get; set; }
        public double Price { get; set; }
        public int TaxRate { get; set; }
        public Sender Sender { get; set; }
        public ShippingStatus ShippingStatus { get; set; }
    }
}
