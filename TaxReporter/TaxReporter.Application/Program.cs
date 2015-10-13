using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxReporter.Core.Services;
using TaxReporter.DependencyResolution;

namespace TaxReporter.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            IoCWrapper.InitContainer();
            var reader = IoCWrapper.Get<IInvoiceReader>();
        }
    }
}
