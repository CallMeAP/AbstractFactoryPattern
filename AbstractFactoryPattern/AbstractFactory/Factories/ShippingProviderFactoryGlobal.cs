using AbstractFactoryPattern.Business.Models.Enums;

namespace AbstractFactoryPattern.AbstractFactory.Factories
{
    public class ShippingProviderFactoryGlobal : ShippingProviderFactoryBase
    {
        protected override ShippingProviderBase CreateShippingProvider(Country country)
        {
            ShippingProviderBase shippingProvider;
            shippingProvider = new GlobalShippingProvider();
            shippingProvider.ShippingCost = 100;

            return shippingProvider;
        }
    }
}
