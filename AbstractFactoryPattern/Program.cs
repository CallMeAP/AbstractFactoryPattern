using AbstractFactoryPattern.AbstractFactory.Factories;
using AbstractFactoryPattern.Business.Models.Commerce;
using AbstractFactoryPattern.Business.Models.Enums;
using System;
using System.Diagnostics;

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
            Console.WriteLine("Simple Factory start");
            sender = new Sender() { Country = Country.Germany };
            order = new Order(sender);
            AbstractFactoryPattern.SimpleFactory.ShoppingCart cart = new AbstractFactoryPattern.SimpleFactory.ShoppingCart(order);
            shippingLabel = cart.FinalizeOrder();
            Console.WriteLine(shippingLabel);
            Console.WriteLine("Simple Factory end");

            Console.WriteLine("-----------------------------------------------");

            // Factory Method (2)
            Console.WriteLine("Factory Method start");
            sender = new Sender() { Country = Country.Global };
            order = new Order(sender);
            
            // pass the suitable factory to the shopping cart based on certain configurations
            // for example, a vip user gets a FreeShippingProviderFactory
            AbstractFactoryPattern.FactoryMethod.Factories.GlobalShippingProviderFactory globalShippingProviderFactory = new AbstractFactoryPattern.FactoryMethod.Factories.GlobalShippingProviderFactory();
            
            // Benefit: the shopping cart is now completely decoupled from the creation of the shipping provider
            AbstractFactoryPattern.FactoryMethod.ShoppingCart cart2 = new AbstractFactoryPattern.FactoryMethod.ShoppingCart(order, globalShippingProviderFactory);
            shippingLabel = cart2.FinalizeOrder();
            Console.WriteLine(shippingLabel);
            Console.WriteLine("Factory Method end");

            Console.WriteLine("-----------------------------------------------");

            // Abstract Factory (3)
            // Is used in cases, where we want to group individual factories that have a common theme
            // hier wirds verwirrend...
            Console.WriteLine("Abstract Factory start");
            sender = new Sender() { Country = Country.Germany };
            order = new Order(sender) { Price = 120 };

            // Factory Provider
            IPurchaseProviderFactory purchaseProviderFactory;
            var factoryProvider = new PruchaseProviderFactoryProvider();
            purchaseProviderFactory = factoryProvider.CreateFactoryFor(order.Sender.Country);

            AbstractFactoryPattern.AbstractFactory.ShoppingCart cart3 = new AbstractFactoryPattern.AbstractFactory.ShoppingCart(order, purchaseProviderFactory);
            shippingLabel = cart3.FinalizeOrder();
            Console.WriteLine(shippingLabel);

            Console.WriteLine("Abstract Factory end");

            Console.WriteLine("-----------------------------------------------");
        }
    }
}
