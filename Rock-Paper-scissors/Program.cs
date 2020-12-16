using System;

namespace Rock_Paper_scissors
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int playerWinsCounter = 0;
            int computerWinsCounter = 0;
            int roundCounter = 1;

            while (roundCounter<6) 
            { 
                var computerChoice = ChoiceComputer();
                if (roundCounter == 1) 
                { 
                    Console.WriteLine($"Current Round: { roundCounter}");
                }
                var playerChoice = ChoicePlayer();
                
                Winner(computerChoice,playerChoice,computerWinsCounter,playerWinsCounter);

                roundCounter++;
                if (roundCounter < 6) 
                {
                    Console.WriteLine($"Current Round : {roundCounter}");
                }
                
            }

        }

        public static string ChoiceComputer()
        {

            // Deklaruojame galimus kompiuterio variantus i sarasa
            string[] computerChoiceList = { "rock", "paper", "scissors" };

            //Sugeneruojame random index reiskme
            var random = new Random();
            int randomIndex = random.Next(0, 3);

            //Issaugome kompiuterio pasirinkima i kintamaji
            var computerChoice = computerChoiceList[randomIndex];
            return  computerChoice;
        }

        public static string ChoicePlayer()
        {
            Console.WriteLine("Enter your choice: Rock Paper or Scissors");

            //Issaugomas zaidejo pasirinkimas ir paverciamas i lowercase 
            string playerChoice = Console.ReadLine().ToLower();

            //Tikriname ar teisingai ivestas zodis 

            while (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
            {
                Console.WriteLine($"OOOoooops wrong word You have entered invalid value \n Please enter:\n Rock Paper or Scissors");

                playerChoice = Console.ReadLine().ToLower();

            }
            return  playerChoice;
        }


        public static void Winner(string playerChoice, string computerChoice, int computerWinsCounter, int playerWinsCounter)
        {
            

            if (playerChoice == "rock" && computerChoice == "rock" || playerChoice == "paper" && computerChoice == "paper" || playerChoice == "scissors" && computerChoice == "scissors")
            {
                Console.WriteLine($"Computer Choose {computerChoice.ToUpper()} and your choice is {playerChoice.ToUpper()} \n It's a DRAW!!!");
            }
            else if (playerChoice == "rock" && computerChoice == "paper" || playerChoice == "paper" && computerChoice == "scissors")
            {
                Console.WriteLine($"Computer Choose {computerChoice.ToUpper()} and your choice is {playerChoice.ToUpper()} \n Player Lost try again");
                computerWinsCounter++;
            }
            else
            {
                Console.WriteLine($"Computer Choose {computerChoice.ToUpper()} and your choice is {playerChoice.ToUpper()} \n Congratz Player  wins!");
                playerWinsCounter++;
            }
            Console.WriteLine($"Game winner decided with BEST OF FIVE RULE!!! Current score is: \n Player: {playerWinsCounter} \n Computer: {computerWinsCounter}");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            
        }
       
    }
}
