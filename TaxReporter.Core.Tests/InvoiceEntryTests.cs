using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxReporter.Core.Models;

namespace TaxReporter.Core.Tests
{
    [TestClass]
    public class InvoiceEntryTests
    {
        private InvoiceEntry entry;
        private string[] correctInput;

        [TestInitialize]
        public void SetUp()
        {
            this.entry = new InvoiceEntry();
            this.correctInput = new[] {"1", "D123", "05-01-2012", "1000"};
        }

        [TestMethod]
        public void should_return_false_on_incorrect_size_array()
        {
            var sample = new[] {"32", "546", "576", "8", "7879", "121345"};
            Assert.IsFalse(entry.PopulateObject(sample));
            Assert.IsNotNull(entry.ErrorMessage);
            Assert.IsTrue(entry.ErrorMessage.StartsWith("Incorrect"));
        }

        [TestMethod]
        public void should_check_for_incorrect_integer_invoice_number()
        {
            var sample = new[] {"Iamwrong", "23", "2323", "46"};
            Assert.IsFalse(entry.PopulateObject(sample));
            Assert.AreEqual(entry.Number,0);
            Assert.IsNotNull(entry.ErrorMessage);
            Assert.IsTrue(entry.ErrorMessage.StartsWith("Invalid Format"));
        }

        [TestMethod]
        public void should_populate_correct_invoice_number()
        {
            Assert.IsTrue(entry.PopulateObject(this.correctInput));
            Assert.IsNull(entry.ErrorMessage);
            Assert.AreEqual(entry.Number,1);
        }
    }
}
