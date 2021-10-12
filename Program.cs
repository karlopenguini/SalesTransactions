using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransactions
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandler.CreateTextFile("Salestrans.txt");
            
            Console.WriteLine("Sales Representative Encoder\n\n");
            List<SalesRep> SalesRepresentatives = new List<SalesRep>();
            List<decimal> sales = new List<decimal>(); ;
            for(int i = 0; i < 5; i++)
            {
                string line;
                SalesRep NewSalesRep = new SalesRep();
                NewSalesRep.Name = NewSalesRep.GetName();
                NewSalesRep.Sales = NewSalesRep.MakeSale();

                sales.Add(NewSalesRep.Sales);
                FileHandler.AppendData($"{NewSalesRep.Name}|{NewSalesRep.Sales}");
            }

            List<string> DataLines = new List<string>();
            FileHandler.ReadData(out DataLines);

            Console.WriteLine("\n\n\n");
            foreach(string line in DataLines)
            {
                string[] parsed = line.Split('|');
                Console.WriteLine($"Name: {parsed[0]}\nSales: {parsed[1]}\n\n");
            }

            Console.WriteLine($"\n\n\nTotal Sales: {Calculator.GetTotalSales(sales)}");
            Console.WriteLine($"Average Sale: {Calculator.GetAverageSale(sales)}");
            Console.WriteLine($"No Sales: {Calculator.GetZeroSales(sales)}\n\n\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

    }
}
