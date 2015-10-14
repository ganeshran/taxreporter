using System;

namespace TaxReporter.Core.Entities
{
    public interface IInvoiceEntry
    {
        int Number { get; set; }

        string Client { get; set; }

        DateTime InvoiceDate { get; set; }

        double Amount { get; set; }

        string ErrorMessage { get; set; }

        bool PopulateObject(string[] line);
    }
}