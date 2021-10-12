using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SalesTransactions
{
    public class FileHandler
    {
        public static void CreateTextFile(string filename)
        {
            FileStream fs = new FileStream("Salestrans.txt", FileMode.Create);
            fs.Close();
        }
        public static void AppendData(string line)
        {
            try
            {
                using (StreamWriter appender = new StreamWriter("Salestrans.txt", true))
                {
                    appender.WriteLine(line);
                }
            }
            catch (UnauthorizedAccessException AccessError)
            {
                Console.WriteLine("\n\nFile Cannot be accesed. Need permission.\n\n");
            }
            catch (FileNotFoundException FileNotFoundError)
            {
                Console.WriteLine("\n\nFile Not Found.\n\n");
            }
        }

        public static void ReadData(out List<string> Lines)
        {
            try
            {
                List<string> lines = File.ReadAllLines("Salestrans.txt").ToList<string>();
                Lines = lines;
                return;
            }
            catch (UnauthorizedAccessException AccessError)
            {
                Console.WriteLine("\n\nFile Cannot be accesed. Need permission.\n\n");
            }
            catch (FileNotFoundException FileNotFoundError)
            {
                Console.WriteLine("\n\nFile Not Found.\n\n");
            }
            Lines = null;
        }
    }
}
