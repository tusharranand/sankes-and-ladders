using System;

namespace snakes_ladders
{
    class Simulation
    {
        public int Roll = 0;
        public int Current_Place = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int NO_PLAY = 0;

        static int Dice()
        {
            return new Random().Next(1, 7);
        }

        static int Check()
        {
            return new Random().Next(0, 3);
        }

        public void Play()
        {
            int Roll = Dice();
            Console.WriteLine("Dice rolled a " + Roll);
            switch (Check())
            {
                case LADDER: 
                    Current_Place = Current_Place + Roll;
                    Console.WriteLine("Player climbed a Ladder");
                    break;
                case SNAKE: 
                    Current_Place = Current_Place - Roll;
                    Console.WriteLine("Player was bit by a Snake");
                    break;
                case NO_PLAY:
                    Console.WriteLine("Player couldn't move");
                    break;
            }
            Console.WriteLine("Current Position of player is: {0} \n", Current_Place);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder game played with single player at start position 0");
            Console.WriteLine("Current Position of player is: 0");
            Simulation start = new Simulation();
            start.Play();
        }
    }
}