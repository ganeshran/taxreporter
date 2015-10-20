using System;
using TaxReporter.Core.DependencyResolution;
using TaxReporter.Core.Enums;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Core.TaxImplementation
{
    public class EducationCess : IDerivedTaxDue
    {
        public EducationCess()
        {
            //This is a violation of IoC.. 
            Name = "Education Cess";
            this.ChildTax = IoCWrapper.Get<ITaxDue>(TaxTypes.ServiceTax.ToString());
        }

        public string Name { get; set; }

        public int CalculateTaxDue(double invoiceAmount)
        {
            return (int) Math.Round(ChildTax.CalculateTaxDue(invoiceAmount)*0.03);
        }

        public ITaxDue ChildTax { get; set; }
    }
}