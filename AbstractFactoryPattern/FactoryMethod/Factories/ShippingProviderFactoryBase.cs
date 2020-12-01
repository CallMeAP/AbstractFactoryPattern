
using AbstractFactoryPattern.Business.Models.Enums;

namespace AbstractFactoryPattern.FactoryMethod.Factories
{
    public abstract class ShippingProviderFactoryBase
    {
        // Design pattern implementation for the Factory Method pattern

        protected abstract ShippingProviderBase CreateShippingProvider(Country country);

        public ShippingProviderBase GetShippingProvider(Country country)
        {
            ShippingProviderBase provider = CreateShippingProvider(country);

            // place code here, that is common for all your shipping provider
            // example if country == Country.Austria then requireAdditionalChecks = false

            return provider;
        }
    }
}
