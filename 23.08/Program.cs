var numbers = NumbersFromUser();

PrintNumbers(numbers);

var average = numbers.Average();
PrintAverage((float)average);


List<int> NumbersFromUser()
{
    var collection = new List<int>();
    int count = InputNumbers("Введите количество чисел коллекции:");
    for (int i = 0; i < count; i++)
    {
        int number = InputNumbers("Введите числа коллекции:");
        collection.Add(number);
    }

    return collection;
}

int InputNumbers(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    return int.Parse(input);
}

void PrintNumbers(IEnumerable<int> collection)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("[ ");
    foreach (var item in numbers!)
    {
        Console.Write($"{item} ");
    }

    Console.WriteLine("]");
    Console.ResetColor();
}

void PrintAverage(float averageInList)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Среднее арифметическое коллекции: {0}", averageInList);
    Console.ResetColor();
}