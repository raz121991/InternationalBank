// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> numbers = new List<int> { 5, 3, 8, 2, 9, 4, 7, 10 };


var evenNumbersSorted = numbers
                        .Where(n => n % 2 == 0) // Filter for even numbers
                        .OrderBy(n => n);       // Sort in ascending order



Console.WriteLine("Even numbers sorted:");
foreach (var num in evenNumbersSorted)
{
    Console.WriteLine(num);
}