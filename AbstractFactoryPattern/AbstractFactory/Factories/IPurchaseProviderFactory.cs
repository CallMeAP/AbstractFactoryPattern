using AbstractFactoryPattern.Business.Models.Commerce;
using AbstractFactoryPattern.Business.Models.Commerce.Invoice;
using AbstractFactoryPattern.Business.Models.Commerce.Summary;

namespace AbstractFactoryPattern.AbstractFactory.Factories
{
    public interface IPurchaseProviderFactory
    {
        ShippingProviderBase CreateShippingProvider(Order order);
        IInvoice CreateInvoice(Order order);
        ISummary CreateSummary(Order order);
    }

    /// <summary>
    /// IPurchaseProviderFactory Implementation for Austria
    /// </summary>
    public class AustriaPurchaseProviderFactory : IPurchaseProviderFactory
    {
        public IInvoice CreateInvoice(Order order)
        {
            return new InvoiceAT();
        }

        public ShippingProviderBase CreateShippingProvider(Order order)
        {
            var shippingProvider = new ShippingProviderFactoryStandard();

            return shippingProvider.GetShippingProvider(order.Sender.Country);
        }

        public ISummary CreateSummary(Order order)
        {
            return new EmailSummary();
        }
    }

    /// <summary>
    /// IPurchaseProviderFactory Implementation for Germany
    /// </summary>
    public class GermanPurchaseProviderFactory : IPurchaseProviderFactory
    {
        public IInvoice CreateInvoice(Order order)
        {
            return new InvoiceDE();
        }

        public ShippingProviderBase CreateShippingProvider(Order order)
        {
            ShippingProviderFactoryBase shippingProvider;

            if (order.Price > 100)
            {
                shippingProvider = new ShippingProviderFactoryGlobal();
            }
            else
            {
                shippingProvider = new ShippingProviderFactoryStandard();
            }

            return shippingProvider.GetShippingProvider(order.Sender.Country);
        }

        public ISummary CreateSummary(Order order)
        {
            return new CsvSummary();
        }
    }
}
