using AbstractFactoryPattern.Business.Models.Commerce;

namespace AbstractFactoryPattern.FactoryMethod
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
