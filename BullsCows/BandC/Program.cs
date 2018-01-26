using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsCows
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            Player player = new Player();
            comp.GenerateNumber();
            do
            {
                string answer = player.Answer();
                comp.Check(answer);
            }
            while (true);
        }
    }
}
