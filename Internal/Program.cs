namespace ConsoleApp_Practice9_part2.Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "Hello!", "My", "Name", "Is", "Snizhana", "I", "am", "a", "student" };

            
            var result = array.OrderByDescending(x => x.Length);
            var result2 = array.OrderBy(x => x.Length);

            Console.WriteLine("Sorting is performed by descending order:");
            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine("Sorting is performed by ascending order:");
            Console.WriteLine(string.Join(", ", result2));
        }
    }
}