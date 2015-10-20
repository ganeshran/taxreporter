using TaxReporter.Core.DependencyResolution;
using TaxReporter.Core.Enums;
using TaxReporter.Core.Factories;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Services.Factories
{
    public class TaxFactory: ITaxFactory
    {
        public ITaxDue GetTaxInstance(TaxTypes type)
        {
            switch (type)
            {
                case TaxTypes.EducationCess:
                    return IoCWrapper.Get<ITaxDue>(type.ToString());
                case TaxTypes.ForeignRemittanceTax:
                        return SimplePerentTaxHelper("Foreign Remittance Tax", 0.05);
                case TaxTypes.ServiceTax:
                        return SimplePerentTaxHelper("Service Tax", 0.10);
                default:
                    return null;
            }
        }

        private ITaxDue SimplePerentTaxHelper(string name, double percentTax)
        {
            var simplePercent = IoCWrapper.Get<ISimplePercentTaxDue>();
            simplePercent.Name = name;
            simplePercent.PercentageTax = percentTax;
            return simplePercent;
        }
    }
}
