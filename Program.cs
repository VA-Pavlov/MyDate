using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySql date = new MySql();
            while (true)
            {
                string command = Console.ReadLine();
                Console.WriteLine(date.determineCommand(command));
            }
            
            
        }
    }
}
