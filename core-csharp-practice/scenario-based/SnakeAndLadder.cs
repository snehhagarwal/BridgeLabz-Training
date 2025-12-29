using System;

class SnakeAndLadder
{
    static Random r=new Random();

    //snake start and end positions
    private int[] snakestart={99,70,52,25};
    private int[] snakeEnd={54,55,42,2};

    //ladder start and end position
    private int[] ladderStart={6,11,46,60};
    private int[] ladderEnd={25,40,90,85};

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to snake and Ladder Game.");
        int choice;

        //take number of players 
        do
        {
            Console.WriteLine("\nMenu for the game: \n");
            Console.WriteLine("1: Start the game");
            Console.WriteLine("2: End the game");
            Console.Write("Enter your choice: ");
            choice=Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Start();
                    break;

                case 2:
                   Console.WriteLine("Game over.\n");
                   break;
                default:
                   Console.WriteLine("Invalid Choice!");
                   break;
            }
        }while(choice!=2);
    }

    static void Start(){

        SnakeAndLadder obj=new SnakeAndLadder();

        Console.Write("Enter number of players: ");

        int playerCount=Convert.ToInt32(Console.ReadLine());

        if(playerCount<2 || playerCount > 4)
        {
                Console.WriteLine("Invalid Number");
                return;
        }

        //storing player name
        string[] players=new string[playerCount];
        //store player positions
        int[] positions=new int[playerCount];

        //take player names
        for(int i = 0; i < playerCount; i++)
        {
            Console.Write("Enter player name: ");
            players[i]=Console.ReadLine();
            positions[i]=0;   //start position
        }

        bool gameOver=false;

        //game loop
        while (!gameOver)
        {
            //turn of each player
            for(int i = 0; i < playerCount; i++)
            {
                Console.WriteLine();
                Console.WriteLine(players[i] + "'s turn. Enter to roll the dice");
                Console.ReadLine();

                int dice=Roll(); //Rolling the dice

                Console.WriteLine(players[i] + " rolled " + dice);
                int oldposition=positions[i]; //previous position

                int newPos=oldposition+dice;  //new position of player

                //edge case
                //if move is greater than 100 skip the move
                positions[i]=newPos>100 ? oldposition : newPos;

                //apply snake or ladder if moved
                if (positions[i] != oldposition)
                {
                    positions[i]=obj.Apply(positions[i],players[i]);
                }

                //updating the positions
                Console.WriteLine("Positions: " + oldposition + " -> " + positions[i]);

                //checking the winning condition
                if (Checking(positions[i]))
                {
                    Console.WriteLine(players[i] + " wins the game!");
                    gameOver=true;
                    break; //exit loop if it ends
                }
            }
        }
        Console.WriteLine("\nGame over.");
    }

    //rolling the dice
    static int Roll()
    {
        return r.Next(1,7);
    }

    public int Apply(int position,string player)
    {
        //checking ladder positions
        for(int i = 0; i < ladderStart.Length; i++)
        {
            if (position == ladderStart[i])
            {
                Console.WriteLine(player + " climbed a ladder");
                return ladderEnd[i];
            }
        }

        //checking snake position
        for(int i = 0; i < snakestart.Length; i++)
        {
            if (position == snakestart[i])
            {
                Console.WriteLine("Oops! " + player + " is bitten by a snake.");
                return snakeEnd[i];
            }
        }

        return position;
    }

    static bool Checking(int position)
    {
        return position==100;
    }

}