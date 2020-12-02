
using System.Text;

namespace AbstractFactoryPattern.Business.Models.Commerce.Invoice
{
    public interface IInvoice
    {
        /// <summary>
        /// Generates a Rechnung
        /// </summary>
        /// <returns></returns>
        public byte[] GenerateInvoice();
    }

    public class InvoiceAT : IInvoice
    {
        public byte[] GenerateInvoice() => Encoding.Default.GetBytes("This is a AT Invoice!");
    }

    public class InvoiceDE : IInvoice
    {
        public byte[] GenerateInvoice() => Encoding.Default.GetBytes("This is a DE Invoice!");
    }

    public class InvoiceGlobal : IInvoice
    {
        public byte[] GenerateInvoice() => Encoding.Default.GetBytes("This is a Global Invoice!");
    }
}
