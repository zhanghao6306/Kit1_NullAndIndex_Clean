using Kit1_NullAndIndexLib;

// Test 1: NullReferenceException
Console.WriteLine("Test 1: Testing NullReferenceException...");
try
{
    string? name = null;
    int length = DangerousOps.LengthOfName(name);
    Console.WriteLine($"Length: {length}");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine($"ArgumentNullException caught: {ex.Message}");
    Console.WriteLine($"Stack trace: {ex.StackTrace}");
}

// Test 2: IndexOutOfRangeException
Console.WriteLine("\nTest 2: Testing IndexOutOfRangeException...");
try
{
    int[] data = DangerousOps.MakeArray(3);
    int value = DangerousOps.GetAt(data, 10);
    Console.WriteLine($"Value: {value}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"ArgumentOutOfRangeException caught: {ex.Message}");
    Console.WriteLine($"Stack trace: {ex.StackTrace}");
}

Console.WriteLine("\nTests completed.");
