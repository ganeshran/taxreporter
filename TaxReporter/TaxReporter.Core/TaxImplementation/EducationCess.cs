using System;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Core.TaxImplementation
{
    public class EducationCess: IDerivedTaxDue
    {
        public string Name { get; set; }

        public EducationCess(ITaxDue childTax)
        {
            this.Name = "Education Cess";
            this.ChildTax = childTax;
        }

        public int CalculateTaxDue(double invoiceAmount)
        {
            return (int) Math.Round(this.ChildTax.CalculateTaxDue(invoiceAmount)*0.03);
        }

        public ITaxDue ChildTax { get; set; }
    }
}
