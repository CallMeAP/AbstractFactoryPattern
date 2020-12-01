using AbstractFactoryPattern.Business.Models.Enums;
using AbstractFactoryPattern.FactoryMethod.Factories;

namespace AbstractFactoryPattern.AbstractFactory.Factories
{
    public class StandardShippingProviderFactory : ShippingProviderFactoryBase
    {
        // creates an instance of an shippingprovider, based on the order country
        protected override ShippingProviderBase CreateShippingProvider(Country country)
        {
            ShippingProviderBase shippingProvider;

            #region Create Shipping Provider
            if (country == Country.Austria)
            {
                shippingProvider = new AustrianShippingProvider();
                shippingProvider.ShippingCost = 0;
            }
            else
            {
                shippingProvider = new GermanShippingProvider();
                shippingProvider.ShippingCost = 20;
            }
            #endregion

            return shippingProvider;
        }
    }


}
