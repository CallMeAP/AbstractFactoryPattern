using AbstractFactoryPattern.Business.Models.Commerce;

namespace AbstractFactoryPattern.SimpleFactory
{
    public abstract class ShippingProviderBase
    {
        public abstract double ShippingCost { get; set; }

        public abstract string GenerateShippingLabel(Order order);
    }
}
