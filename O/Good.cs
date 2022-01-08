using System;

namespace O
{
    public class Good
    {
        internal interface IReportGeneration
        {
            void GenerateReport();
        }

        internal class PdfReportGeneration : IReportGeneration
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating pdf report.");
            }
        }

        internal class CsvReportGeneration : IReportGeneration
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating csv report.");
            }
        }
    }
}