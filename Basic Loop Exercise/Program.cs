//Exercise #1

while (true)
{
    Console.WriteLine("Hello, World!");

    Console.WriteLine("Do you want to run it again? (yes/no)");
    string answer = Convert.ToString(Console.ReadLine());

    if (answer.ToLower().Trim() == "yes")
    {
        continue;
    }
    else if (answer.ToLower().Trim() == "no")
    {
        Console.WriteLine("Catch you later.");
        break;
    }
}
