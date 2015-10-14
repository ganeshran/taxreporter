using System.Collections.Generic;
using TaxReporter.Core.Entities;
using TaxReporter.Core.Services;
using TaxReporter.DependencyResolution;

namespace TaxReporter.Application
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IoCWrapper.InitContainer();
            var reader = IoCWrapper.Get<IInvoiceReaderService>();
            IEnumerable<IParseInvoiceStatus> invoiceInputs = reader.GetInvoiceInputs("D:\\certs\\invoice_data.csv");
        }
    }
}