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
        public int Min_range { get; private set; }
        public int Max_range { get; private set; }
        //public char Key_Control { get; set; }


        public Dice(int num)
        {
            if (_r == null)
            {
                _r = new Random();
            }
            NumberOfDices = num;
            Result = new int[NumberOfDices];
        }

        public void Throw(int min, int max)
        {
            Min_range = min;
            Max_range = max;
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
                    for (int i = 0; i < NumberOfDices; i++)
                    {
                        Result[i] = _r.Next(Min_range, Max_range);
                    }

                }
                String mesg = $"";
                for (int i = 0; i < NumberOfDices; i++)
                {
                    mesg += $"Dice #{i + 1}: {Result[i]} ";
                }
                Console.WriteLine(mesg);
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
            for (int i = 0; i < NumberOfDices; i++)
            {
                Result[i] = _r.Next((Min_range + Max_range) / 2, Max_range);
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
