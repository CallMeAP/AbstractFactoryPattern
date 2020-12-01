using AbstractFactoryPattern.Business.Models.Commerce;

namespace AbstractFactoryPattern.SimpleFactory
{
    class AustrianShippingProvider : ShippingProviderBase
    {
        public override double ShippingCost { get; set; }

        public override string GenerateShippingLabel(Order order)
        {
            return $"Shipping to AT, Cost = {ShippingCost}";
        }
    }
}
