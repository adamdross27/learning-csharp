Console.WriteLine("Hello, World!");

Console.WriteLine("Enter a number: ");
string? answer = Console.ReadLine();

if(!string.IsNullOrEmpty(answer))
{
    Console.WriteLine("You entered: " + answer);
}
else
{
    Console.WriteLine("No input was provided.");
}
