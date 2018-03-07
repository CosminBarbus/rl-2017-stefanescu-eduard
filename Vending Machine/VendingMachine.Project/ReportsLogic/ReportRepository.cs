using System.Collections.Generic;
using System.IO;
using System.Linq;
using VendingMachine.Project.Exceptions;

namespace VendingMachine.Project.ReportsLogic
{
    public class ReportRepository
    {
        private readonly List<Report> _reports;

        public ReportRepository()
        {
            _reports = new List<Report>();
        }

        public void AddReport(Report report)
        {
            _reports.Add(report);
        }

        public void DeleteReport(string reportName)
        {
            if (_reports.Count == 0)
                throw new ReportNotFoundException();
            foreach (var report in _reports.ToList())
            {
                if (report.ReportName == reportName)
                    _reports.Remove(report);
            }
        }

        public void SaveReport(string reportName, string path)
        {
            var report = GetReportByName(reportName);
            var fullPath = $"{path}\\{reportName}.csv";
            using (var reportFile = new StreamWriter(fullPath, true))
            {
                reportFile.WriteLine("Report name:, {0},", report.ReportName);
                foreach (var sale in report.Sales)
                {
                    reportFile.WriteLine("Product name:, {0}", sale.ContainableItem.Product.Name);
                    reportFile.WriteLine("Product price:, {0:C}", sale.ContainableItem.Product.Price);
                    reportFile.WriteLine("Sale date:, {0}\n", sale.SellingDates.Date);
                }
            }
        }

        private Report GetReportByName(string reportName)
        {
            foreach (var report in _reports)
                if (report.ReportName == reportName)
                    return report;
            throw new ReportNotFoundException();
        }

        public List<Report> Reports => new List<Report>(_reports);
    }
}