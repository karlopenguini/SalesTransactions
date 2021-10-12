using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransactions
{
    class Calculator
    {
        public static decimal GetTotalSales(List<decimal> sales)
        {
            decimal totalSales = 0;
            foreach (decimal sale in sales)
            {
                totalSales += sale;
            }

            return Math.Round(totalSales,2);
        }
        public static decimal GetAverageSale(List<decimal> sales)
        {
            decimal totalSales = GetTotalSales(sales);
            int numberOfSales = sales.Count;

            try
            {
                decimal average = Math.Round(totalSales / numberOfSales, 2);
                return average;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("No sales added, Please encode data as number of sales is 0.");
            }
            return 0;
        }

        public static int GetZeroSales(List<decimal> sales)
        {

            int count = sales.FindAll(sale => sale == 0).Count;

            return count;
        }
    }
}
