using System.Runtime.InteropServices;

namespace Containers;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Hello, {RuntimeInformation.OSDescription}  on {RuntimeInformation.RuntimeIdentifier}");
    }
}
