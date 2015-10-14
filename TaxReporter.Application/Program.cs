using System;
using System.Collections.Generic;
using TaxReporter.Core.Entities;
using TaxReporter.Core.Services;
using TaxReporter.DependencyResolution;
using System.Linq;

namespace TaxReporter.Application
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IoCWrapper.InitContainer();
            //Run(args[0]);
            Run("D:\\certs\\invalid_invoice_data.csv");
        }

        public static void Run(string filePath)
        {
            var readerService = IoCWrapper.Get<IInvoiceReaderService>();
            var parseStatus = readerService.GetInvoiceInputs(filePath);
            if (!parseStatus.IsSuccess)
            {
                Console.WriteLine("The input file has invalid data please fix following errors and try again:");
                int lineNum = 1;
                parseStatus.Entries.ForEach(x =>
                    {
                        if (x.ErrorMessage != null) Console.WriteLine("Line {0} - {1}", lineNum, x.ErrorMessage);
                        lineNum++;
                    });
            }
        }
    }
}