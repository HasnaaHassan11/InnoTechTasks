using System.Text;

Console.WriteLine("Please, Enter the maximum number.");
int maxNumber = int.Parse(Console.ReadLine() ?? "0");
if (maxNumber <= 0)
{
    Console.WriteLine("The number less than 1");
    return;
}

#region Writing numbers with string concatenation
var watch = System.Diagnostics.Stopwatch.StartNew();
string resultWithString = string.Empty;
for (int i = 1; i <= maxNumber; i++)
{
    resultWithString += $"{i},";
}
resultWithString = resultWithString.TrimEnd(',');
Console.WriteLine($"The numbers from 1 to {maxNumber} are:\n {resultWithString}");
watch.Stop();
Console.WriteLine($"Time taken using string concatenation: {watch.ElapsedMilliseconds} ms");
#endregion

#region Writing numbers with StringBuilder
watch.Restart();
var resultWithStringBuilder = new StringBuilder();
for (int i = 1; i <= maxNumber; i++)
{
    resultWithStringBuilder.Append(i);
    if (i < maxNumber)
    {
        resultWithStringBuilder.Append(",");
    }
}
Console.WriteLine($"The numbers from 1 to {maxNumber} are:\n {resultWithStringBuilder}");
watch.Stop();
Console.WriteLine($"Time taken using StringBuilder: {watch.ElapsedMilliseconds} ms");
#endregion
