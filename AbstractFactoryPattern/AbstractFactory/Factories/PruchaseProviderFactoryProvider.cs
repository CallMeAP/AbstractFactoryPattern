using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using AbstractFactoryPattern.Business.Models.Enums;

namespace AbstractFactoryPattern.AbstractFactory.Factories
{
    public class PruchaseProviderFactoryProvider
    {
        private IEnumerable<Type> factories;

        public PruchaseProviderFactoryProvider()
        {
            factories = Assembly.GetAssembly(typeof(PruchaseProviderFactoryProvider))
                .GetTypes()
                .Where(t => typeof(IPurchaseProviderFactory).IsAssignableFrom(t));
        }

        public IPurchaseProviderFactory CreateFactoryFor(Country country)
        {
            string target = new string((char[])country.ToString().SkipLast(1).ToArray());
            
            // find a factory based on the provided name
            var factory = factories.FirstOrDefault(x => x.Name.ToLowerInvariant().StartsWith(target.ToLowerInvariant()));

            return (IPurchaseProviderFactory)Activator.CreateInstance(factory);
        }
    }
}
