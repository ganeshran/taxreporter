using System;
using System.Collections.Generic;
using System.IO;
using TaxReporter.Core.Entities;
using TaxReporter.Core.Models;
using TaxReporter.Core.Services;

namespace TaxReporter.Services.Input
{
    public class CsvInvoiceReaderService : IInvoiceReaderService
    {
        public IParseInvoiceStatus GetInvoiceInputs(string filePath)
        {
            var result = new ParseInvoiceStatus();
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Input File not Found");

            var fileReader = new StreamReader(filePath);
            string line = String.Empty;
            while ((line = fileReader.ReadLine()) != null)
            {
                result.AddEntry(line);
            }
            return result;
        }
    }
}