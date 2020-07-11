using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klazzwork
{//
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 1");
            ConsoleKeyInfo symbol;
            int count = 0;
            do
            {
                symbol = Console.ReadKey();
                if (symbol.KeyChar == ' ') count++;
            }
            while (symbol.KeyChar != '.');


            Console.WriteLine("task 2");
            string sticketnumber;
            int iticketnumber;
            bool isTicketNumberValid = false;
            do
            {
                sticketnumber = Console.ReadLine();
                if(sticketnumber.Length == 6 && int.TryParse(sticketnumber, out iticketnumber))
                {
                    isTicketNumberValid = true;
                }
            }
            while (!isTicketNumberValid);
            int leftpart = 0, rightpart = 0;
            for(int i = 0; i < sticketnumber.Length; i++)
            {
                if (i < 3) leftpart += int.Parse(sticketnumber[i].ToString());
                else rightpart += int.Parse(sticketnumber[i].ToString());
            }

            bool isTicketLucky = leftpart == rightpart;
            Console.WriteLine(isTicketLucky);

        }
    }
}
