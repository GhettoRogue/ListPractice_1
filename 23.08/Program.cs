var numbers = NumbersFromUser();

PrintNumbers(numbers);

var average = numbers.Average();
PrintAverage(average);


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
    Console.Write("Вывод коллекции: ");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("[ ");
    foreach (var item in numbers!)
    {
        Console.Write($"{item} ");
    }

    Console.WriteLine("]");
    Console.ResetColor();
}

void PrintAverage(double averageInList)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Среднее арифметическое коллекции: {0}", averageInList);
    Console.ResetColor();
}