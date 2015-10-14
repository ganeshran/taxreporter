using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxReporter.Core.Entities;

namespace TaxReporter.Core.Models
{
    public class ParseInvoiceStatus: IParseInvoiceStatus
    {
        public IInvoiceEntry InvoiceEntry { get; set; }
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }

        public ParseInvoiceStatus(string input)
        {
            var line = input.Split(',');
            if (line.Length != 4)
            {
                this.ErrorMessage = "Incorrect number of Columns";
                this.IsSuccess = false;
                this.InvoiceEntry = null;
            }
            this.InvoiceEntry = new InvoiceEntry();
            if (!this.InvoiceEntry.PopulateObject(line))
            {
                this.IsSuccess = false;
                this.ErrorMessage = InvoiceEntry.ErrorMessage;
            }

            this.IsSuccess = true;
        }
    }
}
