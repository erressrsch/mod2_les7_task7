namespace mod2_les7_task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = [];

            Console.WriteLine("Enter 3 numbers separated by a comma: ");
            string userinput = Console.ReadLine();
            string[] words = userinput.Split(',');

            foreach (var word in words)
            {
                numbers.Add(int.Parse(word));
            }
            numbers.Sort();
            Console.WriteLine();
            Console.WriteLine($"{numbers.Max()} is the largest number given");

        }
    }
}