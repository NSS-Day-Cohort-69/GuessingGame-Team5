// Create function "GuessingGame"
    // Display greeting in Console.Write
    // Declare int variable for user's guess, guess1
    // try & catch to ensure we get user's guess... Console.ReadLine
    // Console.WriteLine guess1

void GuessingGame()
{
    Console.WriteLine("Welcome to Oinky Toinky's Guessing Game!");
    int guess1 = 0;
    int secretNumber = 42;
    GuessingTries();


    void GuessingTries()
    {
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
    int incorrectCount = 0;
    while (incorrectCount < 3 && guess1 != secretNumber)
    {
        
        if (incorrectCount < 3)
        {
            incorrectCount++;
            Console.WriteLine("That was awful, try again!");
            guess1 = 0;
            GuessingTries();
     
        }
    }
    if (incorrectCount == 3)
    {
        Console.WriteLine("DIE");
    }
    else
    {
        Console.WriteLine("Good job, im so proud of you!");
    }
}
GuessingGame();

