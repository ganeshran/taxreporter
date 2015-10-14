namespace TaxReporter.Core.Taxes
{
    public interface IDerivedTaxDue : ITaxDue
    {
        ITaxDue ChildTax { get; set; }
    }
}