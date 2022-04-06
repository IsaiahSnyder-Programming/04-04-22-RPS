using RPS.models;
// See https://aka.ms/new-console-template for more information
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;
Console.Clear();
bool running = true;
int computerScore = 0;
int playerScore = 0;
while (running)
{
    // string greeting = "Do you want to play a game? (yes/no)\n";
    // for (int i = 0; i < greeting.Length; i++)
    // {
    //     Console.Write(greeting[i]);
    //     Thread.Sleep(10);
    // }

    // string answer = Console.ReadLine().ToLower();
    // if (answer == "yes")
    // {
    //     Thread.Sleep(1000);
    //     Console.Clear();

    // }
    // if (answer == "no")
    // {
    //     System.Console.WriteLine("Aw!");
    // }



    // SECTION Rock Paper Scissors
    {
        // NOTE Game Start
        string leave = "Type 'leave' to leave the game.\n";
        string score = "Computer: " + computerScore + " | Player: " + playerScore + "\n";
        string gameStart = "Rock, Paper, Scissors:\n";
        for (int i = 0; i < leave.Length; i++)
        {
            Console.Write(leave[i]);
            Thread.Sleep(35);
        }
        Thread.Sleep(1000);
        for (int i = 0; i < score.Length; i++)
        {
            Console.Write(score[i]);
            Thread.Sleep(35);
        }
        for (int i = 0; i < gameStart.Length; i++)
        {
            Console.Write(gameStart[i]);
            Thread.Sleep(20);
        }


        // NOTE Rock
        string item = Console.ReadLine().ToLower();
        if (item == "rock")
        {
            // NOTE Rock Paper Scissors Shoot
            string rpss = "\nRock, Paper, Scissors, Shoot!\n";
            for (int i = 0; i < rpss.Length; i++)
            {
                Console.Write(rpss[i]);
                Thread.Sleep(15);
            }

            // NOTE Random Int
            static int rnd(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }
            int num = rnd(1, 100);

            // NOTE Rock
            if (num >= 1 && num <= 25)
            {
                string choice = "\nThe Computer chose Rock!";
                string win = "\nIts a Tie!";
                for (int i = 0; i < choice.Length; i++)
                {
                    Console.Write(choice[i]);
                    Thread.Sleep(20);
                }
                Thread.Sleep(500);
                for (int i = 0; i < win.Length; i++)
                {
                    Console.Write(win[i]);
                    Thread.Sleep(20);
                }
                Thread.Sleep(3000);
                Console.Clear();
            }
            else if (num >= 26 && num <= 50)
            {
                string choice = "\nThe Computer chose Paper!";
                string win = "\nYou Lose!";
                for (int i = 0; i < choice.Length; i++)
                {
                    Console.Write(choice[i]);
                    Thread.Sleep(20);
                }
                Thread.Sleep(500);
                for (int i = 0; i < win.Length; i++)
                {
                    Console.Write(win[i]);
                    Thread.Sleep(20);
                }
                computerScore++;
                Thread.Sleep(3000);
                Console.Clear();
            }
            else if (num >= 51 && num <= 75)
            {
                string choice = "\nThe Computer chose Scissors!";
                string win = "\nYou Win!";
                for (int i = 0; i < choice.Length; i++)
                {
                    Console.Write(choice[i]);
                    Thread.Sleep(20);
                }
                Thread.Sleep(500);
                for (int i = 0; i < win.Length; i++)
                {
                    Console.Write(win[i]);
                    Thread.Sleep(20);
                }
                playerScore++;
                Thread.Sleep(3000);
                Console.Clear();
            }
            else if (num >= 76 && num <= 100)
            {
                string fool = "\nYou Fool!!!";
                string choice = "\nThe Computer Chose Dynamite!!!";
                string win = "\nPrepare to lose";
                string dots = "...";
                for (int i = 0; i < fool.Length; i++)
                {
                    Console.Write(fool[i]);
                    Thread.Sleep(20);
                }
                Thread.Sleep(2000);
                for (int i = 0; i < choice.Length; i++)
                {
                    Console.Write(choice[i]);
                    Thread.Sleep(30);
                }
                Thread.Sleep(2000);
                for (int i = 0; i < win.Length; i++)
                {
                    Console.Write(win[i]);
                    Thread.Sleep(100);
                }
                Thread.Sleep(1000);
                for (int i = 0; i < dots.Length; i++)
                {
                    Console.Write(dots[i]);
                    Thread.Sleep(1000);
                }
                Thread.Sleep(1000);
                running = false;
                Console.Clear();
            }
            else
            {
                System.Console.WriteLine("\nIdk bro, the RNG gods got a lil freaky...\nSorry");
                Thread.Sleep(1500);
                Console.Clear();
            }
            Thread.Sleep(100);
        }


        // NOTE Paper
        if (item == "paper")
        {
            // NOTE Rock Paper Scissors Shoot
            string rpss = "\nRock, Paper, Scissors, Shoot!\n";
            for (int i = 0; i < rpss.Length; i++)
            {
                Console.Write(rpss[i]);
                Thread.Sleep(15);
            }

            // NOTE Random Int
            static int rnd(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }
            int num = rnd(1, 100);

            if (num >= 1 && num <= 25)
            {
                string choice = "\nThe Computer chose Paper!";
                string win = "\nIts a Tie!";
                for (int i = 0; i < choice.Length; i++)
                {
                    Console.Write(choice[i]);
                    Thread.Sleep(20);
                }
                Thread.Sleep(500);
                for (int i = 0; i < win.Length; i++)
                {
                    Console.Write(win[i]);
                    Thread.Sleep(20);
                }
                Thread.Sleep(3000);
                Console.Clear();
            }
            else if (num >= 26 && num <= 50)
            {
                string choice = "\nThe Computer chose Scissors!";
                string win = "\nYou Lose!";
                for (int i = 0; i < choice.Length; i++)
                {
                    Console.Write(choice[i]);
                    Thread.Sleep(20);
                }
                Thread.Sleep(500);
                for (int i = 0; i < win.Length; i++)
                {
                    Console.Write(win[i]);
                    Thread.Sleep(20);
                }
                computerScore++;
                Thread.Sleep(3000);
                Console.Clear();
            }
            else if (num >= 51 && num <= 75)
            {
                string choice = "\nThe Computer chose Rock!";
                string win = "\nYou Win!";
                for (int i = 0; i < choice.Length; i++)
                {
                    Console.Write(choice[i]);
                    Thread.Sleep(20);
                }
                Thread.Sleep(500);
                for (int i = 0; i < win.Length; i++)
                {
                    Console.Write(win[i]);
                    Thread.Sleep(20);
                }
                playerScore++;
                Thread.Sleep(3000);
                Console.Clear();
            }
            else if (num >= 76 && num <= 100)
            {
                string fool = "\nYou Fool!!!";
                string choice = "\nThe Computer Chose Dynamite!!!";
                string win = "\nPrepare to lose";
                string dots = "...";
                for (int i = 0; i < fool.Length; i++)
                {
                    Console.Write(fool[i]);
                    Thread.Sleep(20);
                }
                Thread.Sleep(2000);
                for (int i = 0; i < choice.Length; i++)
                {
                    Console.Write(choice[i]);
                    Thread.Sleep(30);
                }
                Thread.Sleep(2000);
                for (int i = 0; i < win.Length; i++)
                {
                    Console.Write(win[i]);
                    Thread.Sleep(100);
                }
                Thread.Sleep(1000);
                for (int i = 0; i < dots.Length; i++)
                {
                    Console.Write(dots[i]);
                    Thread.Sleep(1000);
                }
                Thread.Sleep(1000);
                running = false;
                Console.Clear();
            }
            else
            {
                System.Console.WriteLine("\nIdk bro, the RNG gods got a lil freaky...\nSorry");
                Thread.Sleep(1500);
                Console.Clear();
            }
            Thread.Sleep(100);
        }


        // NOTE Scissors
        if (item == "scissors")
        {
            // NOTE Rock Paper Scissors Shoot
            string rpss = "\nRock, Paper, Scissors, Shoot!\n";
            for (int i = 0; i < rpss.Length; i++)
            {
                Console.Write(rpss[i]);
                Thread.Sleep(15);
            }

            // NOTE Random Int
            static int rnd(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }
            int num = rnd(1, 100);

            if (num >= 1 && num <= 25)
            {
                string choice = "\nThe Computer chose Scissors!";
                string win = "\nIts a Tie!";
                for (int i = 0; i < choice.Length; i++)
                {
                    Console.Write(choice[i]);
                    Thread.Sleep(20);
                }
                Thread.Sleep(500);
                for (int i = 0; i < win.Length; i++)
                {
                    Console.Write(win[i]);
                    Thread.Sleep(20);
                }
                Thread.Sleep(3000);
                Console.Clear();
            }
            else if (num >= 26 && num <= 50)
            {
                string choice = "\nThe Computer chose Rock!";
                string win = "\nYou Lose!";
                for (int i = 0; i < choice.Length; i++)
                {
                    Console.Write(choice[i]);
                    Thread.Sleep(20);
                }
                Thread.Sleep(500);
                for (int i = 0; i < win.Length; i++)
                {
                    Console.Write(win[i]);
                    Thread.Sleep(20);
                }
                computerScore++;
                Thread.Sleep(3000);
                Console.Clear();
            }
            else if (num >= 51 && num <= 75)
            {
                string choice = "\nThe Computer chose Paper!";
                string win = "\nYou Win!";
                for (int i = 0; i < choice.Length; i++)
                {
                    Console.Write(choice[i]);
                    Thread.Sleep(20);
                }
                Thread.Sleep(500);
                for (int i = 0; i < win.Length; i++)
                {
                    Console.Write(win[i]);
                    Thread.Sleep(20);
                }
                playerScore++;
                Thread.Sleep(3000);
                Console.Clear();
            }
            else if (num >= 76 && num <= 100)
            {
                string fool = "\nYou Fool!!!";
                string choice = "\nThe Computer Chose Dynamite!!!";
                string win = "\nPrepare to lose";
                string dots = "...";
                for (int i = 0; i < fool.Length; i++)
                {
                    Console.Write(fool[i]);
                    Thread.Sleep(20);
                }
                Thread.Sleep(2000);
                for (int i = 0; i < choice.Length; i++)
                {
                    Console.Write(choice[i]);
                    Thread.Sleep(30);
                }
                Thread.Sleep(2000);
                for (int i = 0; i < win.Length; i++)
                {
                    Console.Write(win[i]);
                    Thread.Sleep(100);
                }
                Thread.Sleep(1000);
                for (int i = 0; i < dots.Length; i++)
                {
                    Console.Write(dots[i]);
                    Thread.Sleep(1000);
                }
                Thread.Sleep(1000);
                running = false;
                Console.Clear();
            }
            else
            {
                System.Console.WriteLine("\nIdk bro, the RNG gods got a lil freaky...\nSorry");
                Thread.Sleep(1500);
                Console.Clear();
            }
            Thread.Sleep(100);
        }

    }
}