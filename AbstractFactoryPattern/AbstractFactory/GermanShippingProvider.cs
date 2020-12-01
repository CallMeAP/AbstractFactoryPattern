using AbstractFactoryPattern.Business.Models.Commerce;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class GermanShippingProvider : ShippingProviderBase
    {
        public override double ShippingCost { get; set; }

        public override string GenerateShippingLabel(Order order)
        {
            return $"Shipping to Germany, cost = {ShippingCost}";
        }
    }
}
