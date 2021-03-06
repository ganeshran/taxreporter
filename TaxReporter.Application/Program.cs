﻿using System;
using System.Collections.Generic;
using TaxReporter.Core.DependencyResolution;
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
            BootStrapper.InitContainer();
            Run("D:\\certs\\invoice_data.csv");
        }

        public static void Run(string filePath)
        {
            var readerService = IoCWrapper.Get<IInvoiceReaderService>();
            var reporterService = IoCWrapper.Get<IOutputReportService>();


            var parseStatus = readerService.GetInvoiceInputs(filePath);
            if (!parseStatus.IsSuccess)
            {
                Console.WriteLine(parseStatus.AggregateErrorMessages());
                return;
            }
            Console.WriteLine(reporterService.Header);
            Console.WriteLine(reporterService.OutputReport(parseStatus.Entries));
        }
    }
}