using AbstractFactoryPattern.Business.Models.Commerce;
using AbstractFactoryPattern.Business.Models.Enums;
using AbstractFactoryPattern.FactoryMethod.Factories;

namespace AbstractFactoryPattern.FactoryMethod
{
    public class ShoppingCart
    {
        private Order order;
        private ShippingProviderFactoryBase shippingProviderFactoryBase;

        public ShoppingCart(Order order, ShippingProviderFactoryBase shippingProviderFactory)
        {
            this.order = order;
            this.shippingProviderFactoryBase = shippingProviderFactory;
        }

        public string FinalizeOrder()
        {
            ShippingProviderBase shippingProvider = shippingProviderFactoryBase.GetShippingProvider(order.Sender.Country);
            order.ShippingStatus = ShippingStatus.ReadyForShipment;
            return shippingProvider.GenerateShippingLabel(order);
        }
    }
}
