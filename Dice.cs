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
        //public char Key_Control { get; set; }

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
            //Key_Control = Console.ReadKey(true).KeyChar;
            ConsoleKeyInfo key_control = Console.ReadKey(true);
            //Console.TreatControlCAsInput = true;

            while (!(key_control.KeyChar.Equals('q') || key_control.KeyChar.Equals('Q'))) {
                if (DiceMischief(key_control))
                {
                    DiceCheater();
                }
                else
                {
                    Result[0] = _r.Next(1, 7);
                    Result[1] = _r.Next(1, 7);
                }
                Console.WriteLine($"Dice One: {Result[0]} Dice Two: {Result[1]}");
                Console.WriteLine("Press Any Key To Continue or 'Q' to Quit :");
                key_control = Console.ReadKey(true);
            }
                
        }

        public bool DiceMischief(ConsoleKeyInfo k_c)
            /*
             * Dice Solemny Swears Is up to no Good
             * 
             */
        {
         
            if (((k_c.Modifiers & ConsoleModifiers.Control) != 0) && (k_c.Key == ConsoleKey.O))
            {
                return true;
            }
            return false;
        }


        public void DiceCheater()
        {
            Result[0] = _r.Next(4, 7);
            Result[1] = _r.Next(4, 7);
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
