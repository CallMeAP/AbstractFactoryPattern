using AbstractFactoryPattern.Business.Models.Enums;

namespace AbstractFactoryPattern.SimpleFactory
{
    public class ShippingProviderFactory
    {
        // creates an instance of an shippingprovider, based on the order country
        public static ShippingProviderBase CreateShippingProvider(Country country)
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
