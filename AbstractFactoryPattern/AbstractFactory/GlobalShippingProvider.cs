﻿using AbstractFactoryPattern.Business.Models.Commerce;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class GlobalShippingProvider : ShippingProviderBase
    {
        public override double ShippingCost { get; set; }

        public override string GenerateShippingLabel(Order order)
        {
            return $"Global-Express, cost = {ShippingCost}";
        }
    }
}
