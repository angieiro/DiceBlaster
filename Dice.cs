using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceBlaster
{
    class Dice
    {
        private static Random _r { get; set; } //γεννήτρια ζαριών
        public int[] Result { get; set; }
        public int NumberOfDices { get; private set; }
        public char Key_Control { get; set; }

        public Dice()
        {
            if (_r == null)
            {
                _r = new Random();
            }
            Result = new int[2];
        }

        public void Throw()
        {
            Console.WriteLine("Press Any Key:");
            Key_Control = Console.ReadKey().KeyChar;
            while (!(Key_Control.Equals('q') || Key_Control.Equals('Q'))) {
                Result[0] = _r.Next(1, 7);
                Result[1] = _r.Next(1, 7);
                Console.WriteLine($"Dice One: {Result[0]} Dice Two: {Result[1]}");
                Console.WriteLine("Press Any Key To Continue or 'Q' to Quit :");
                Key_Control = Console.ReadKey().KeyChar;
            }
                
        }

        /*public void Throw(int Number)
        {
            for (int i = 0; i < NumberOfDices; i++)
            {
                Result[i] = _r.Next(1, 7);
            }
        }*/
    }
}
