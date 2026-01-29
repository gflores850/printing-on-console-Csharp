namespace how_far_i_can_go_with_this
{
    internal class Model
    {
        Dictionary<int, string> id = new()
        {
            [1] = "15134651351",
            [2] = "561356546",
            [3] = "456546464564"
        };
        public List<string> user = new()
            {
                "Alice", "Alice@gmail.com",
                "Bob", "Bob@icloud.com",
                "Charlie", "Charlie@outlook.com"
            };
        public void Names()
        {
            foreach (var number in id)
            {
                Console.WriteLine($"{number.Key}: {number.Value}");
            }
            foreach (var person in user)
            {
                Console.WriteLine($"user:{person}");
            }
        }
    }
}
