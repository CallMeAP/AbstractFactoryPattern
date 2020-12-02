using System.Diagnostics;
using System.Text;

namespace AbstractFactoryPattern.Business.Models.Commerce.Summary
{
    public interface ISummary
    {
        string CreateOrderSummary(Order order);

        void Send();
    }

    public class EmailSummary : ISummary
    {
        public string CreateOrderSummary(Order order)
        {
            return "This is a Email Summary!";
        }

        public void Send()
        {
            Debug.WriteLine("EmailSummary -> Send() called!");
        }
    }

    public class CsvSummary : ISummary
    {
        public string CreateOrderSummary(Order order)
        {
            return "This is a Csv Summary!";
        }

        public void Send()
        {
            Debug.WriteLine("CsvSummary -> Send() called!");
        }
    }
}
