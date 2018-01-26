using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsCows
{
    class Computer
    {
        char[] charArray = new char[3];
        public char[] GenerateNumber()
        {
            Random r = new Random();

            int a = r.Next(0, 10);
            charArray[0] = r.Next(0, 10).ToString()[0];
            do
            {
                charArray[1] = r.Next(0, 10).ToString()[0];
            }
            while (charArray[0] == charArray[1]);
            do
            {
                charArray[2] = r.Next(0, 10).ToString()[0];
            }
            while (charArray[0] == charArray[2] && charArray[1] == charArray[2]);

            return charArray;
        }
        public void Check(string number)
        {
            int bull = 0;
            int cow = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == charArray[i])
                    bull++;
            }
            if (bull == 3)
            {
                Console.WriteLine("You win!");
                Environment.Exit(1);
            }
            if (number[0] == charArray[1] || number[0] == charArray[2])
                cow++;
            if (number[1] == charArray[0] || number[1] == charArray[2])
                cow++;
            if (number[2] == charArray[0] || number[2] == charArray[1])
                cow++;
            Console.WriteLine($"Bull -  {bull}, Cow - {cow}");
        }
    }
}
