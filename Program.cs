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

    if (guess1 == secretNumber){
        Console.WriteLine("Hazzuh you did it! I'm so proud of you <3");
    } else {
        Console.WriteLine("DIE");
    }
}

GuessingGame();

//creating secret number variable hard coded
// remove display of users guess
//if else to compare guess to secret number display either success or failure message