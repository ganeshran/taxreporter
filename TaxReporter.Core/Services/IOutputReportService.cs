using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaxReporter.Core.Entities;

namespace TaxReporter.Core.Services
{
    public interface IOutputReportService
    {
        string OutputReport(List<IInvoiceEntry> invoiceEntries);

        string Header { get; set; }
    }
}
