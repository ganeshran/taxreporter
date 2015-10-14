using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxReporter.Services.Input;

namespace TaxReporter.Services.Tests
{
    [TestClass]
    public class CsvInvoiceReaderTests
    {
        private CsvInvoiceReaderService _readerService;

        [TestInitialize]
        public void Setup()
        {
            this._readerService = new CsvInvoiceReaderService();
        }

        [TestMethod]
        public void GetInvoiceEntry()
        {
            var invoice = _readerService.GetInvoiceInputs("D:\\certs\\invoice_data.csv");
        }
    }
}
