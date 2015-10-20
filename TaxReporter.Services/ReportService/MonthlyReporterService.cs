using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaxReporter.Core.DependencyResolution;
using TaxReporter.Core.Entities;
using TaxReporter.Core.Services;

namespace TaxReporter.Services.ReportService
{
    public class MonthlyReporterService: IOutputReportService
    {
        class Taxes
        {
            public double Amount { get; set; }
            public int ST { get; set; }
            public int EC { get; set; }
            public int FRT { get; set;}
        }
        private ITaxCalculatorService domesticCalculator;
        private ITaxCalculatorService internationalTaxCalculator;
        private Dictionary<string, Taxes> rolledUpInvoices; 

        public MonthlyReporterService()
        {
            this.domesticCalculator = IoCWrapper.Get<ITaxCalculatorService>("Domestic");
            this.internationalTaxCalculator = IoCWrapper.Get<ITaxCalculatorService>("International");
            this.Header = "Month | Total Invoice Amount | ST | EC | FRT";
            this.rolledUpInvoices = new Dictionary<string, Taxes>();
        }

        public string OutputReport(List<IInvoiceEntry> invoiceEntries)
        {
            var reportLine = new StringBuilder();
            var st = 0;
            var ec = 0;
            var frt = 0;
            foreach (var invoiceEntry in invoiceEntries)
            {
                var key = invoiceEntry.InvoiceDate.ToString("mm-yyyy");
                if (!this.rolledUpInvoices.ContainsKey(key))
                    this.rolledUpInvoices.Add(key, new Taxes());
                rolledUpInvoices[key].Amount += invoiceEntry.Amount;
                if (invoiceEntry.Client.StartsWith("D"))
                {
                    rolledUpInvoices[key].ST +=
                        domesticCalculator.TaxesDue.First(x => x.Name == "Service Tax")
                                          .CalculateTaxDue(invoiceEntry.Amount);
                    rolledUpInvoices[key].EC +=
                        domesticCalculator.TaxesDue.First(x => x.Name == "Education Cess")
                                          .CalculateTaxDue(invoiceEntry.Amount);
                }
                else
                {
                    rolledUpInvoices[key].FRT +=
                        internationalTaxCalculator.TaxesDue.First(x => x.Name == "Foreign Remittance Tax")
                                                  .CalculateTaxDue(invoiceEntry.Amount);
                }

            }

            var total = new Taxes();
            foreach (var month in rolledUpInvoices)
            {
                reportLine.AppendLine(string.Format("{0} | {1} | {2} | {3} | {4}", month.Key, month.Value.Amount, month.Value.ST,
                                                    month.Value.EC, month.Value.FRT));
                total.Amount += month.Value.Amount;
                total.EC += month.Value.EC;
                total.ST += month.Value.ST;
                total.FRT += month.Value.FRT;
            }
            reportLine.AppendLine(string.Format("Total | {0} | {1} | {2} | {3}", total.Amount, total.ST, total.EC, total.FRT));

            return reportLine.ToString();
        }

        public string Header { get; set; }
    }
}
