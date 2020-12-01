using AbstractFactoryPattern.Business.Models.Commerce;
using AbstractFactoryPattern.Business.Models.Enums;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Sender sender;
            Order order;
            string shippingLabel;

            // Simple Factory (1)
            sender = new Sender() { Country = Country.Germany };
            order = new Order(sender);
            AbstractFactoryPattern.SimpleFactory.ShoppingCart cart = new AbstractFactoryPattern.SimpleFactory.ShoppingCart(order);
            shippingLabel = cart.FinalizeOrder();
            Console.WriteLine(shippingLabel);

            // Factory Method (2)
            sender = new Sender() { Country = Country.Global };
            order = new Order(sender);
            
            // pass the suitable factory to the shopping cart based on certain configurations
            // for example, a vip user gets a FreeShippingProviderFactory
            AbstractFactoryPattern.FactoryMethod.Factories.GlobalShippingProviderFactory globalShippingProviderFactory = new AbstractFactoryPattern.FactoryMethod.Factories.GlobalShippingProviderFactory();
            
            // Benefit: the shopping cart is now completely decoupled from the creation of the shipping provider
            AbstractFactoryPattern.FactoryMethod.ShoppingCart cart2 = new AbstractFactoryPattern.FactoryMethod.ShoppingCart(order, globalShippingProviderFactory);
            shippingLabel = cart2.FinalizeOrder();
            Console.WriteLine(shippingLabel);

            // Abstract Factory (3)
        }
    }
}
