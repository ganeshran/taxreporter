using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaxReporter.Core.Entities;
using TaxReporter.Core.Services;

namespace TaxReporter.Services.ReportService
{
    public class MonthlyReporterService: IOutputReportService
    {
        private IDomesticTaxCalculatorService domesticCalculator;
        private IInternationalTaxCalculatorService internationalTaxCalculator;
        private Dictionary<string, List<IInvoiceEntry>> rolledUpInvoices; 

        public MonthlyReporterService(IDomesticTaxCalculatorService _domesticTaxCalculatorService,
                                      IInternationalTaxCalculatorService _internationalTaxCalculatorService)
        {
            this.domesticCalculator = _domesticTaxCalculatorService;
            this.internationalTaxCalculator = _internationalTaxCalculatorService;
            this.Header = "Month | Total Invoice Amount | ST | EC | FRT";
        }

        public string OutputReport(List<IInvoiceEntry> invoiceEntries)
        {
            var reportLine = new StringBuilder();
            var st = 0;
            var ec = 0;
            var frt = 0;
            foreach (var invoiceEntry in invoiceEntries)
            {
                string key = invoiceEntry.InvoiceDate.ToString("MM-yyyy");
                if(!this.rolledUpInvoices.ContainsKey(key))
                    this.rolledUpInvoices.Add(key,new List<IInvoiceEntry>());
                rolledUpInvoices[key].Add(invoiceEntry);
            }
            return null;
        }

        public string Header { get; set; }
    }
}
