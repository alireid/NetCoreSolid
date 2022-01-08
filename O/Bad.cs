using System;

namespace O
{
    public class Bad
    {
        public class ReportGeneration
        {
            public string ReportType { get; set; }

            /// <summary>
            /// Method to generate report
            /// </summary>
            /// <param name="employee"></param>
            public void GenerateReport(Employee employee)
            {
                if (ReportType == "CRS")
                {
                    // Report generation with employee data in Crystal Report.
                }
                if (ReportType == "PDF")
                {
                    // Report generation with employee data in PDF.
                }
            }
        }
    }
}