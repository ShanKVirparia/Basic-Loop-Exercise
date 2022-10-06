//Door lock

bool doorLocked = true;

while (doorLocked)
{
    Console.WriteLine("Welcome. Please enter your 5 digit door code: ");
    int doorcode = Convert.ToInt32(Console.ReadLine());

    if (doorcode != 13579)
    {
        Console.WriteLine($"Please try again. You entered {doorcode}");
        continue;
    }
    else if (doorcode == 13579)
    {
        Console.WriteLine("Welcome Home!");
        Console.ReadKey();
        break;
    }
}