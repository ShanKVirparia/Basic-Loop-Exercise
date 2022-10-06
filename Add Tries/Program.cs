
bool doorLocked = true;
int tries = 0;

while (doorLocked)
{
    
    Console.WriteLine("Welcome. Please enter your 5 digit door code: ");
    int doorCodeAttempt = Convert.ToInt32(Console.ReadLine());

    if (doorCodeAttempt != 13579)
    {
        Console.WriteLine($"Please try again. You entered {doorCodeAttempt}");
        tries++;

        if(tries > 5)
        {
            Console.WriteLine("To many tries.");
            Console.ReadKey();
            break;
        }

        continue;
    }
    
    else if (doorCodeAttempt == 13579)
    {
        Console.WriteLine("Welcome Home!");
        Console.ReadKey();
        break;
    }
    
}