// See https://aka.ms/new-console-template for more information

bool run = true;

if (args.Length == 0 || args.Length > 1)
{
    Console.WriteLine("Enter an intiger. q to exit.\n");
    while (run)
    {
        string number = Console.ReadLine();
        run = countDigits(number);
    }
}
else
{
    Console.WriteLine(args[0]);
    string number = args[0].ToString();
    run = countDigits(number);
}

static bool countDigits(string number)
{
    List<char> digits = new List<char>();
    bool run = true;
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
    else if (IsFloat(number))
    {
        float.TryParse(number, out float value2);
        if (value2 < 0)
            value2 = value2 * (-1);

        number = value2.ToString();
        digits.AddRange(number);
        Console.WriteLine("Number of all digits: " + (digits.Count - 1));
        digits = digits.Distinct().ToList();  //getting rid of duplicates
        Console.WriteLine("Number of digits but duplicates doesn't count: " + (digits.Count - 1));
        digits.Clear();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("The input must be an intiger");
    }
    Console.WriteLine();

    return run;
}

static bool IsFloat(string number)
{
    float floatnumber;
    return float.TryParse(number, out floatnumber);
}