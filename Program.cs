namespace Rock_paper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string player;
            string computer;
            string answer;

            bool Playagain = true;

            while (Playagain)
            {
                player = "";
                computer = "";


                while (player != "Rock" && player != "Paper" && player != "Scissors")

                {
                    Console.Write("Enter Rock, paper or scissors: ");
                    player = Console.ReadLine();
                }

                int randomnum = random.Next(1, 4);

                switch (randomnum)
                {
                    case 1:
                        computer = "Rock";
                        break;
                    case 2:
                        computer = "Paper";
                        break;
                    case 3:
                        computer = "Scissors";
                        break;

                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("computer: " + computer);

                switch (player)
                {
                    case "Rock":
                        if (computer == "Rock")
                        {
                            Console.WriteLine("It's a draw!");
                        }

                        else if (computer == "Paper")
                        {
                            Console.WriteLine("You lose. Computer won the round!");
                        }
                        else if (computer == "Scissors")
                        {
                            Console.WriteLine("You won!");
                        }
                        break;

                    case "Paper":
                        if (computer == "Paper")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "Rock")
                        {
                            Console.WriteLine("You won!");
                        }
                        else if (computer == "Scissors ")
                        {
                            Console.WriteLine("You lose. Computer won the round!");
                        }
                        break;

                    case "Scissors":
                        if (computer == "Scissors")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "Paper")
                        {
                            Console.WriteLine("You won!");
                        }
                        else if (computer == "Rock ")
                        {
                            Console.WriteLine("You lose. Computer won the round!");
                        }
                        break;
                }

                Console.WriteLine("Would you like to play again?");
                answer = Console.ReadLine();

                if (answer == "yes")
                {
                    Playagain = true;
                }
                else if (answer == "no")
                {
                    Playagain = false;
                }

            }
        }
    }
}