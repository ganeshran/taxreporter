using System;
using TaxReporter.Core.DependencyResolution;
using TaxReporter.Core.Enums;
using TaxReporter.Core.Factories;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Services.Taxes
{
    public class EducationCess : IDerivedTaxDue
    {
        public EducationCess(ITaxFactory taxFactory)
        {
            //This is a violation of IoC.. 
            Name = "Education Cess";
            this.ChildTax = taxFactory.GetTaxInstance(TaxTypes.ServiceTax);
        }

        public string Name { get; set; }

        public int CalculateTaxDue(double invoiceAmount)
        {
            return (int) Math.Round(ChildTax.CalculateTaxDue(invoiceAmount)*0.03);
        }

        public ITaxDue ChildTax { get; set; }
    }
}