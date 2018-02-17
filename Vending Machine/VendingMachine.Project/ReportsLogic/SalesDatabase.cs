using System;
using System.Collections.Generic;
using VendingMachine.Project.Exceptions;

namespace VendingMachine.Project.ReportsLogic
{
    public class SalesDatabase
    {
        private readonly List<Sale> _sales;
        private static SalesDatabase _salesDatabase;
        private static readonly object Synlock = new object();

        private SalesDatabase()
        {
            _sales = new List<Sale>();
        }

        public static SalesDatabase Instance
        {
            get
            {
                if (_salesDatabase == null)
                    lock (Synlock)
                        if (_salesDatabase == null)
                            _salesDatabase = new SalesDatabase();
                return _salesDatabase;
            }
        }

        public void AddSale(Sale sale)
        {
            _sales.Add(sale);
        }

        public void RemoveSale(Sale sale)
        {
            if (_sales.Count == 0)
                throw new SalesNotFoundException();
            _sales.Remove(sale);
        }

        public List<Sale> GetSalesByDate(DateTime startDate, DateTime endDate)
        {
            var sales = new List<Sale>();
            foreach (var sale in _sales)
            {
                if (sale.SellingDates.Date >= startDate && sale.SellingDates.Date <= endDate)
                    sales.Add(sale);
            }
            if (sales.Count == 0)
                throw new SalesNotFoundException();
            return sales;
        }

        public List<Sale> Sales => new List<Sale>(_sales);
    }
}