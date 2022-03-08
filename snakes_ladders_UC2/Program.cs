using System;

namespace snakes_ladders
{
    class simulation
    {
        public int Roll = 0;
        public int Score = 0;

        static int Dice()
        {
            return new Random().Next(1, 7);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder game played with single player at start position 0");
            int Roll = Dice();
            Console.WriteLine(Roll);
        }
    }
}