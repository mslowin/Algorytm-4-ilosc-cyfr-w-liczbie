// See https://aka.ms/new-console-template for more information


bool run= true;
List<char> digits = new List<char>();


Console.WriteLine("Enter an intiger. q to exit.\n");


while (run)
{
    string number = Console.ReadLine();
    if (number == "q")
    {
        run = false;
    }
    else if (int.TryParse(number, out int value)) // if the input is an intiger
    {
        if (value < 0)
            value = value * (-1);

        number = value.ToString();
        digits.AddRange(number);
        Console.WriteLine("Number of all digits: " + digits.Count);
        digits = digits.Distinct().ToList();  //getting rid of duplicates
        Console.WriteLine("Number of digits but duplicates doesn't count: " + digits.Count);
        digits.Clear();

    }
    else
    {
        Console.Clear();
        Console.WriteLine("The input must be an intiger");
    }
    Console.WriteLine();
}


