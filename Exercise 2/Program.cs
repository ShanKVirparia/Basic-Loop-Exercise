//Exercise #2 For loop

while (true)
{
    Console.WriteLine("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    for (int i = number; i >= 0; i--)
    {
        Console.WriteLine(i);
    }

    for(int i = 0; i <= number; i++)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("Do you want to run it again? (yes/no)");
    string answer = Convert.ToString(Console.ReadLine());

    if (answer.ToLower().Trim() == "yes")
    {
        continue;
    }
    else if (answer.ToLower().Trim() == "no")
    {
        Console.WriteLine("Catch you later.");
        Console.ReadKey();
        break;
    }
}

