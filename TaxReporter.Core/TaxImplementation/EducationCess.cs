using System;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Core.TaxImplementation
{
    public class EducationCess : IDerivedTaxDue
    {
        public EducationCess()
        {
            Name = "Education Cess";
        }

        public EducationCess(ServiceTax childTax) : this()
        {
            ChildTax = childTax;
        }

        public string Name { get; set; }

        public int CalculateTaxDue(double invoiceAmount)
        {
            return (int) Math.Round(ChildTax.CalculateTaxDue(invoiceAmount)*0.03);
        }

        public ITaxDue ChildTax { get; set; }
    }
}