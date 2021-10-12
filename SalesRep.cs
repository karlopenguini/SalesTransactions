using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransactions
{
    class SalesRep : Validator
    {
        private string _name;
        private decimal _sales;
        public string Name
        {
            get;
            set;
        }
        public decimal Sales
        {
            get;
            set;
        }
        public string GetName()
        {
            bool validName;
            string name = "";
            do
            {
                Console.Write("Name: ");
                string nameInput = Console.ReadLine();
                validName = !IsEmpty(nameInput)
                    && IsAlphabetical(nameInput, out name);

            } while (!validName);

            return name;
        }

        public decimal MakeSale()
        {
            bool validSale;
            decimal sale = 0;
            do
            {
                Console.Write($"Sales by {Name}: ");
                string saleInput = Console.ReadLine();
                
                validSale = !IsEmpty(saleInput)
                          && IsNumber(saleInput, out sale)
                          &&!IsNegative(sale);

            } while (!validSale);
            return Math.Round(sale,2);
        } 
    }
}
