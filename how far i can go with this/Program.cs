using how_far_i_can_go_with_this;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Dictionary<int, string> numbers = new()
        {
            [1] = "One",
            [2] = "Two",
            [3] = "Three"
        };
        Console.WriteLine();

        Model mymodel = new Model();
        mymodel.Names();

        foreach (var number in numbers)
        {
            Console.WriteLine($"{number.Key}: {number.Value}");

        }
        Console.WriteLine();
        Console.WriteLine("user list");
        foreach (var person in mymodel.user)
        {
            Console.WriteLine($"user:{person}");
        }
    }
}