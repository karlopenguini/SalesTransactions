using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransactions
{
    class Validator
    {
        internal bool IsNumber(string input, out decimal sale)
        {
            if(!decimal.TryParse(input, out sale))
            {
                Console.WriteLine("\n\nSales must be a number\n\n");
                return false;
            }
            return true;
        }

        internal bool IsAlphabetical(string input, out string name)
        {
            if (!input.All(letter => Char.IsWhiteSpace(letter)) && input.All(letter => Char.IsWhiteSpace(letter) || Char.IsLetter(letter)))
            {
                name = input;
                return true;
            }
            Console.WriteLine("Name must only contain letters and whitespaces.");
            name = "INVALID";
            return false;
            
        }

        internal bool IsNegative(decimal input)
        {
            if (input < 0)
            {
                Console.WriteLine("\n\nSales must not be negative\n\n");
                return true;
            }
            return false;
        }

        internal bool IsEmpty(string input)
        {
            if(input.Length == 0)
            {
                Console.WriteLine("\n\nInput Must not be Empty\n\n");
                return true;
            }
            return false;
        }
    }
}
