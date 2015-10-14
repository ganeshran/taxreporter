using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxReporter.Core.Taxes
{
    public interface ITaxDue
    {
        string Name { get; set; }
        int CalculateTaxDue(double invoiceAmount);
    }
}
