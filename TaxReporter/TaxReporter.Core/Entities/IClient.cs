using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxReporter.Core.Enums;

namespace TaxReporter.Core.Entities
{
    public interface IClient
    {
        ClientType Type { get; set; }
        int ClientNumber { get; set; }
    }
}
