using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxReporter.Core.Entities;
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
            _readerService = new CsvInvoiceReaderService();
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void should_throw_on_invalid_file_path()
        {
            _readerService.GetInvoiceInputs("this file path doesn't exist");
        }

        [TestMethod]
        public void should_read_file_correctly()
        {
            var invoiceInputs = _readerService.GetInvoiceInputs("invoice_data.csv");
            //We will only test the ability of the code to read the csv files
            //Not actually check for the parsing logic because that code will be written
            //in the test case for parsing
            Assert.AreEqual(invoiceInputs.Entries.Count,7);
        }
    }
}