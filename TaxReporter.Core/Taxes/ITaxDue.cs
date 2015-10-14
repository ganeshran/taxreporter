namespace TaxReporter.Core.Taxes
{
    public interface ITaxDue
    {
        string Name { get; set; }
        int CalculateTaxDue(double invoiceAmount);
    }
}