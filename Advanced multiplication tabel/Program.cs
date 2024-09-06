Console.Write("Skriv in tal du vill ha tabell på :");

string input = Console.ReadLine();

string[] numberStrings = input.Split(' ');

int[] numbers =new int [numberStrings.Length];

for (int i = 0; i < numberStrings.Length; i++)
{
    numbers[i] = int.Parse(numberStrings[i]);
}

foreach (int number in numbers)
{
    Console.WriteLine($"Multiplikationstabell för {number} : ");
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{number} x {j} = {number * j}");
    }
    Console.WriteLine();
}