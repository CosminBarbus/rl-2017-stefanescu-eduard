using System;
using VendingMachine.Project.Exceptions;
using VendingMachine.Project.PaymentLogic;
using VendingMachine.Project.ProductsLogic;
using VendingMachine.Project.ReportsLogic;

namespace VendingMachine.ConsoleUI
{
    class Program
    {
        static void Main()
        {
            var paymentTerminal = new PaymentTerminal();
            var reportRepository = new ReportRepository();
            try
            {
                // Vending Machine Out Of Service
                var pringlesItem = ProductFactory.CreatePringlesProduct();
                ProductBand.Instance.Add(pringlesItem);
                var dispenser = new Dispenser();
                paymentTerminal.Subscribe(dispenser);
            }
            catch (Exception exception)
            {
                if (exception is BandIsFullException)
                    Console.WriteLine("Band is full! It can't store any items.");
            }

            try
            {
                // New Customer Requests for a Pringles
                var visaCard = new CreditCard("4012888888881881");
                paymentTerminal.Pay(visaCard, 1, "Pringles");
            }
            catch (Exception exception)
            {
                if (exception is CardNotValidException)
                    Console.WriteLine("This credit card is not valid! Try another payment method.");
                if (exception is CardNotFoundException)
                    Console.WriteLine("Card was not found! Payment canceled!");
                if (exception is BandIsEmptyException)
                    Console.WriteLine("Band is empty! You can't {0} any item!", exception.Message);
                if (exception is ProductNotFoundException)
                    Console.WriteLine("The product was not found!");
            }

            try
            {
                // Analyst Created a Report for february month
                var februaryStartDate = new DateTime(2018, 02, 01);
                var februaryEndDate = new DateTime(2018, 02, 28);
                var februarySales = SalesDatabase.Instance.GetSalesByDate(februaryStartDate, februaryEndDate);
                var report = new Report("FebruaryReport.csv", februarySales);
                reportRepository.AddReport(report);
            }
            catch (Exception exception)
            {
                if (exception is ReportNotFoundException)
                    Console.WriteLine("Report was not found!");
                if (exception is SalesNotFoundException)
                    Console.WriteLine("Sales were not found!");
            }

            Console.ReadKey();
        }
    }
}
