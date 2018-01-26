using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsCows
{
    class Player
    {
        public string Answer()
        {
            Console.WriteLine("Guess the number");
            string answer = Console.ReadLine();

            return answer;
        }
    }
}
