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

        public int Dice()
        {
            return new Random().Next(1, 7);
        }

        public int Check()
        {
            return new Random().Next(0, 3);
        }

        public void Play()
        {
            while (Current_Place < 100)
            {
                int Roll = Dice();
                switch (Check())
                {
                    case LADDER:
                        Current_Place = Current_Place + Roll;
                        break;
                    case SNAKE:
                        Current_Place = Current_Place - Roll;
                        if (Current_Place <= 0)
                            {
                                Current_Place = 0;
                            }
                        break;
                    case NO_PLAY:
                        break;
                }
                Console.WriteLine("Current Position of player is: {0} \n", Current_Place);
            }

            Console.WriteLine("The player reached 100th position.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder game played with single player at start position 0");
            Console.WriteLine("Current Position of player is: 0 \n");
            Simulation start = new Simulation();
            start.Play();
        }
    }
}