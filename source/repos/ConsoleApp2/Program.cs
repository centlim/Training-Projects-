using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

var fibonacciNumbers = new List<int> { 1, 1 };
for (int i = 0; i <= 17; i++)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count];

    fibonacciNumbers.Add(previous + previous2);
  
    }
foreach (var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}





