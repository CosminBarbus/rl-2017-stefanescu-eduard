using System.Collections.Generic;
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

        public List<Report> Reports => new List<Report>(_reports);
    }
}