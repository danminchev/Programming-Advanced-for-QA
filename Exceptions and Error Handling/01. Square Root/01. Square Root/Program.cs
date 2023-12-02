try
{
    int number = int.Parse(Console.ReadLine());

    if (number < 0)
    {
        throw new ArgumentException();
    }

    double squareRoot = Math.Sqrt(number);

    Console.WriteLine(squareRoot);
}
catch (ArgumentException)
{
    Console.WriteLine("Invalid number.");
}
catch (FormatException)
{
    Console.WriteLine("Invalid format.");
}
finally
{
    Console.WriteLine("Goodbye.");
}