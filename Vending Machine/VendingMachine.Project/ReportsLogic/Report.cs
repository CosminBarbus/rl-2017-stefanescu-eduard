using System.Collections.Generic;

namespace VendingMachine.Project.ReportsLogic
{
    public class Report
    {
        private readonly string _reportName;
        private readonly List<Sale> _sales;

        public Report(string reportName, List<Sale> sales)
        {
            _reportName = reportName;
            _sales = sales;
        }

        public string ReportName => _reportName;

        public List<Sale> Sales => new List<Sale>(_sales);
    }
}
