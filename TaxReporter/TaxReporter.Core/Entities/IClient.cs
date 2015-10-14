using TaxReporter.Core.Enums;

namespace TaxReporter.Core.Entities
{
    public interface IClient
    {
        ClientType Type { get; set; }
        int ClientNumber { get; set; }
    }
}