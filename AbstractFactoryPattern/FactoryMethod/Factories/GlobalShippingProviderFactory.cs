using AbstractFactoryPattern.Business.Models.Enums;

namespace AbstractFactoryPattern.FactoryMethod.Factories
{
    public class GlobalShippingProviderFactory : ShippingProviderFactoryBase
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
