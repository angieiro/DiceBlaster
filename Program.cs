using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceBlaster
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Set the number of dices: ");
            int num = Int32.Parse(Console.ReadLine());
            Dice dice = new Dice(num);
            Console.WriteLine("Set the minimum of dice range: ");
            int min = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Set the maximum of dice range: ");
            int max = Int32.Parse(Console.ReadLine());
            dice.Throw(min, max);

        }
    }
}
