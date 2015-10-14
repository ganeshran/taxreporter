using System;
using System.Globalization;
using TaxReporter.Core.Entities;

namespace TaxReporter.Core.Models
{
    /// <summary>
    ///     Only the implementations for the entities should be in the CoreProject - which are
    ///     pure data entities without behaviour
    /// </summary>
    public class InvoiceEntry : IInvoiceEntry
    {
        public int Number { get; set; }
        public string Client { get; set; }
        public DateTime InvoiceDate { get; set; }
        public double Amount { get; set; }
        public string ErrorMessage { get; set; }

        public bool PopulateObject(string[] line)
        {
            int number;
            double amount;
            DateTime invDate;
            
            if (line.Length != 4)
            {
                this.ErrorMessage = "Incorrect number of Data Elements in the Input";
                return false;
            }

            if (!int.TryParse(line[0], out number))
            {
                ErrorMessage = "Invalid Format for Invoice Number";
                return false;
            }
            Number = number;

            if (!line[1].StartsWith("D") && !line[1].StartsWith("I"))
            {
                ErrorMessage = "Invalid Format for Client Number";
                return false;
            }
            Client = line[1];

            if (!DateTime.TryParseExact(line[2], "dd-mm-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,  out invDate))
            {
                ErrorMessage = "Invalid Format for Date";
                return false;
            }
            InvoiceDate = invDate;

            if (!double.TryParse(line[3], out amount))
            {
                ErrorMessage = "Invalid Format for Invoice amount";
                return false;
            }
            Amount = amount;
            return true;
        }
    }
}