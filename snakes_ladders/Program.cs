using System;

namespace snakes_ladders
{
    class Simulation
    {
        public int Roll = 0;
        public int Num_of_Rolls = 0;
        public int Snake_Bites = 0;
        public int Ladder_Climbs = 0;
        public int No_Moves = 0;
        public int Current_Place = 0;
        public int Last_Place = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int NO_PLAY = 0;

        public int Dice()
        {
            Random Rolling = new Random();
            int Roll = Rolling.Next(1, 7);
            Num_of_Rolls++;
            return Roll;
        }

        public int Check()
        {
            return new Random().Next(0, 3);
        }

        public void Play()
        {
            while (Current_Place < 100)
            {
                Last_Place = Current_Place;
                int Roll = Dice();
                switch (Check())
                {
                    case LADDER:
                        Current_Place = Current_Place + Roll;
                        Ladder_Climbs++;
                        break;
                    case SNAKE:
                        Current_Place = Current_Place - Roll;
                        Snake_Bites++;
                        if (Current_Place <= 0)
                            {
                                Current_Place = 0;
                            }
                        break;
                    case NO_PLAY:
                        No_Moves++;
                        break;
                }
                if (Current_Place > 100)
                {
                    Current_Place = Last_Place;
                }
                Console.WriteLine("Current Position of player is: {0} \n", Current_Place);
            }

            Console.WriteLine("The player reached 100th position.");
            Console.WriteLine("Number of times the dice was rolled = {0} \n" +
                "Number of times player climbed a ladder = {1} \n" +
                "Number of times the player was bitten by a snake = {2} \n" +
                "Number of times the player wa frozen in place = {3}", Num_of_Rolls, Ladder_Climbs, Snake_Bites, No_Moves);
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