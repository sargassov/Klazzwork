using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klazzwork
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo symbol;
            int count = 0;
            do
            {
                symbol = Console.ReadKey();
                if (symbol.KeyChar == ' ') count++;
            }
            while (symbol.KeyChar != '.');
            
        }
    }
}
