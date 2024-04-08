// Create function "GuessingGame"
    // Display greeting in Console.Write
    // Declare int variable for user's guess, guess1
    // try & catch to ensure we get user's guess... Console.ReadLine
    // Console.WriteLine guess1
Random random = new Random();


void GuessingGame()
{

     int guess1 = 0;

    int secretNumber = random.Next(1, 101);
    
    
    Console.WriteLine("Welcome to Oinky Toinky's Guessing Game!");
    int choice = 0;
      int incorrectCount = -5;
    while ( choice == 0) {
        Console.WriteLine(@"1. Easy
        2. Medium
        3. Hard");

        try {
            int response = int.Parse(Console.ReadLine()!.Trim());
            choice = response;
            if (choice > 0 && choice < 4){
                GuessingTries( choice );
            }
        }
        catch (FormatException){
            Console.WriteLine("Please only choose integers");
        }
        
    }
    
   

    
        

    void GuessingTries(int choice)
    {
    
    
        
        if ( choice == 1 && incorrectCount == -5){
            incorrectCount = -4;
        }
        else if (choice == 2 && incorrectCount == -5){
            incorrectCount = -2;
        }
        else if ( choice == 3 && incorrectCount == -5){
            incorrectCount = 0;
        }
        

        while (guess1 < 1 || guess1 > 100)
        {
            Console.Write("Guess a number: ");
            try
            {
                int response = int.Parse(Console.ReadLine()!.Trim());
                guess1 = response;

                if (guess1 < 1 || guess1 > 100)
                {
                    Console.WriteLine("Please choose a number 1-100!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please choose only intergers!");
            }
        }
    }
   
    
    
    while (incorrectCount < 3 && guess1 != secretNumber)
    {
        
        if (incorrectCount < 3)
        {
            incorrectCount++;
            if (guess1 > secretNumber){
                Console.WriteLine(@$"Your guess was too high bro! 
Your guess: {guess1}. 
You have {4 - incorrectCount} guesses left.");
            }
            else if ( guess1 < secretNumber){
                Console.WriteLine(@$"Your guess is too Low Bro!
Your guess: {guess1}. 
You have {4 - incorrectCount} guesses left.");
Console.WriteLine(incorrectCount);
            }
        
            Console.WriteLine($"{secretNumber}");
            guess1 = 0;
            GuessingTries(choice);
     
        }
    }
    if (incorrectCount == 3 && guess1 != secretNumber)
    
    {
        Console.WriteLine("DIE! GAME OVER!");
    }
    else
    {
        Console.WriteLine("Good job, im so proud of you! Game over!");
    }
}
GuessingGame();