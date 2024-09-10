Console.Write("Please input an integer:");
if (int.TryParse(Console.ReadLine(), out int number) && number > 1)
{
    Console.WriteLine($"{number}'s all prime factors are:");
    FindPrimeFactors(number);
}
else
{
    Console.WriteLine("Please input an integer bigger than 1!");
}

static void FindPrimeFactors(int number)
{
    while (number % 2 == 0)
    {
        Console.Write("2 ");
        number /= 2;
    }

    for (var i = 3; i <= Math.Sqrt(number); i += 2)
    {
        while (number % i == 0)
        {
            Console.Write($"{i} ");
            number /= i;
        }
    }
    if (number > 2)
    {
        Console.Write($"{number}");
    }
}
