using System.Collections.Generic;
using TaxReporter.Core.Entities;

namespace TaxReporter.Core.Services
{
    /// <summary>
    ///     This class is an abstraction for reading in Invoices from various sources
    ///     Our current requirements needs this to be only from a CSV file but that might
    ///     change in the future
    /// </summary>
    public interface IInvoiceReaderService
    {
        IParseInvoiceStatus GetInvoiceInputs(string filePath);
    }
}