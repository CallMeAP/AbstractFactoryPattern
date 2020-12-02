using AbstractFactoryPattern.Business.Models.Commerce;
using AbstractFactoryPattern.Business.Models.Enums;
using AbstractFactoryPattern.AbstractFactory.Factories;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class ShoppingCart
    {
        private Order order;
        private IPurchaseProviderFactory purchaseProviderFactory;

        public ShoppingCart(Order order, IPurchaseProviderFactory purchaseProviderFactory)
        {
            this.order = order;
            this.purchaseProviderFactory = purchaseProviderFactory;
        }

        /// <summary>
        /// Creates shipping label for a specific order
        /// </summary>
        /// <returns></returns>
        public string FinalizeOrder()
        {
            ShippingProviderBase shippingProvider = purchaseProviderFactory.CreateShippingProvider(order);
            purchaseProviderFactory.CreateInvoice(order);
            var summary = purchaseProviderFactory.CreateSummary(order);
            summary.Send();

            order.ShippingStatus = ShippingStatus.ReadyForShipment;
            return shippingProvider.GenerateShippingLabel(order);
        }
    }
}
