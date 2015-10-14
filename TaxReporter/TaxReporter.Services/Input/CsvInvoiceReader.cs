using System;
using System.Collections.Generic;
using System.IO;
using TaxReporter.Core.Entities;
using TaxReporter.Core.Models;
using TaxReporter.Core.Services;

namespace TaxReporter.Services.Input 
{
    public class CsvInvoiceReaderService: IInvoiceReaderService
    {
        public IEnumerable<IParseInvoiceStatus> GetInvoiceInputs(string filePath)

        {
            if(!File.Exists(filePath))
                throw new FileNotFoundException("Input File not Found");

            var fileReader = new StreamReader(filePath);
            var line = string.Empty;
            while ((line = fileReader.ReadLine()) != null)
            {
                yield return new ParseInvoiceStatus(line);
            }
        }
    }
}
