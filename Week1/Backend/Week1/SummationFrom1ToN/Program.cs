Console.WriteLine("Please, Enter the maximum number.");
int maxNumber = int.Parse(Console.ReadLine() ?? "0");
if (maxNumber <= 0)
{
    Console.WriteLine("The number less than 1");
    return;
}

#region Summation with for loop
var watch = System.Diagnostics.Stopwatch.StartNew();
int sumWithForLoop = 0;
for (int i = 1; i <= maxNumber; i++)
{
    sumWithForLoop += i;
}
Console.WriteLine($"The sum of numbers from 1 to {maxNumber} using a for loop is: {sumWithForLoop}");
watch.Stop();
Console.WriteLine($"Time taken using for loop: {watch.ElapsedMilliseconds} ms");
#endregion

#region Summation with formula
watch.Restart();
int sumWithFormula = (maxNumber * (maxNumber + 1)) / 2;
Console.WriteLine($"The sum of numbers from 1 to {maxNumber} using the formula is: {sumWithFormula}");
watch.Stop();
Console.WriteLine($"Time taken using formula: {watch.ElapsedMilliseconds} ms");
#endregion
