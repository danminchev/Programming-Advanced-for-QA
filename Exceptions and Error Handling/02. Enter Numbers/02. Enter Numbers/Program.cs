static int ReadNumber (int start, int end)
{
    int number = int.Parse(Console.ReadLine());

    if (number <= start || number >= end)
    {
        throw new ArgumentException(); 
    }

    return number;
}

List<int> numbers = new List<int>();
int pervNum = 1;

while (numbers.Count < 10)
{
    try
    {
        int num = ReadNumber(pervNum, 100);

        numbers.Add(num);
        pervNum = num;
    }
    catch (ArgumentException)
    {
        Console.WriteLine($"Your number is not in range {pervNum} - 100!");
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid Number!");
    }
}
Console.WriteLine(string.Join(", ", numbers));