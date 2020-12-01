using AbstractFactoryPattern.Business.Models.Commerce;
using AbstractFactoryPattern.Business.Models.Enums;

namespace AbstractFactoryPattern.SimpleFactory
{
    public class ShoppingCart
    {
        private Order order;

        public ShoppingCart(Order order)
        {
            this.order = order;
        }

        public string FinalizeOrder()
        {
            // the shopping cart shouldn't be concerned about the creation details of an ShippingProvider
            ShippingProviderBase shippingProvider = ShippingProviderFactory.CreateShippingProvider(order.Sender.Country);
            
            order.ShippingStatus = ShippingStatus.ReadyForShipment;
            
            return shippingProvider.GenerateShippingLabel(order);
        }
    }
}
