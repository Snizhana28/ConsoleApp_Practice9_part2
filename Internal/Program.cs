namespace ConsoleApp_Practice9_part2.Internal
{
    internal class Program
    {
        static void PrintArray(IEnumerable<int> array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 8 };
            int[] array2 = { 1, 15, 4, 13, 12, 1, 9 };

            var difference = array1.Except(array2);
            var intersection = array1.Intersect(array2);
            var union = array1.Union(array2);
            var distinct = array1.Distinct();

            Console.WriteLine("Difference two arrays:");
            PrintArray(difference);
            
            Console.WriteLine("\nIntersection two arrays:");
            PrintArray(intersection);

            Console.WriteLine("\nUnion two arrays:");
            PrintArray(union);

            Console.WriteLine("\nDistinct array:");
            PrintArray(distinct);
        }
    }
}