using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxReporter.Core.Enums;
using TaxReporter.Core.Services;
using TaxReporter.Core.Taxes;
using TaxReporter.DependencyResolution;

namespace TaxReporter.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            IoCWrapper.InitContainer();
            var ec = IoCWrapper.Get<ITaxDue>("EC");
        }
    }
}
