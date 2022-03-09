using System;

namespace snakes_ladders
{
    class Simulation
    {
        public int Roll = 0;
        public int Num_of_Rolls = 0;
        public int Current_Place_One = 0;
        public int Current_Place_Two = 0;
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

        public void Play(string Player)
        {
            bool Turn = true;
            while (Turn && Current_Place < 100)
            {
                Last_Place = Current_Place;
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
                        Turn = false;
                        break;
                    case NO_PLAY:
                        Turn = false;
                        break;
                }
                if (Current_Place > 100)
                {
                    Current_Place = Last_Place;
                }
                Console.WriteLine("Current Position of {0} is: {1} \n", Player, Current_Place);
            }
        }

        static void Main(string[] args)
        {
            int Turn = 1;
            Console.WriteLine("Snake and Ladder game played with single player at start position 0");
            Console.WriteLine("Current Position of players is: 0 \n");
            Simulation Player_One = new Simulation();
            Simulation Player_Two = new Simulation();
            while (Player_One.Current_Place < 100 && Player_Two.Current_Place < 100)
            {
                if (Turn == 1)
                {
                    Player_One.Play("Player 1");
                    Turn = 2;
                }
                else if (Turn == 2)
                {
                    Player_Two.Play("Player 2");
                    Turn = 1;
                }
            }
            Console.WriteLine("The player reached 100th position.\n");
            Console.WriteLine("Number of times the dice was rolled by Player 1 = {0}", Player_One.Num_of_Rolls);
            Console.WriteLine("Number of times the dice was rolled by Player 2 = {0}", Player_Two.Num_of_Rolls);
        }
    }
}