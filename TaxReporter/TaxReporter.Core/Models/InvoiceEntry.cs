using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxReporter.Core.Entities;

namespace TaxReporter.Core.Models
{
    /// <summary>
    /// Only the implementations for the entities should be in the CoreProject - which are 
    /// pure data entities without behaviour
    /// </summary>
    public class InvoiceEntry: IInvoiceEntry 
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

            if (!int.TryParse(line[0], out number))
            {
                this.ErrorMessage = "First column not a number"; 
                return false;
            }
            this.Number = number;

            if (!line[1].StartsWith("D") || !line[1].StartsWith("I"))
            {
                this.ErrorMessage = "Invalid Client Number";
                return false;
            }
            this.Client = line[1];

            if (!DateTime.TryParse(line[2], out invDate))
            {
                this.ErrorMessage = "Invalid Date";
                return false;
            }
            this.InvoiceDate = invDate;

            if (!double.TryParse(line[3], out amount))
            {
                this.ErrorMessage = "Invalid Format for Invoice amount";
                return false;
            }
            this.Amount = amount;
            return true;

        }
    }
}
