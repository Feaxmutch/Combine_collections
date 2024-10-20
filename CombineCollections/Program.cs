namespace CombineCollections
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers1 = new() { 6, 5, 2 };
            List<int> numbers2 = new() { 6, 9, 2 };
            List<int> numbers3 = new() { 3, 4, 6 };
            List<int> numbers4 = new() { 3, 1, 3 };
            List<int>[] allNumbers = { numbers1, numbers2, numbers3, numbers4 };

            List<int> combinedNumbers = CombineCollections(allNumbers);

            foreach (var number in combinedNumbers)
            {
                Console.Write($"{number} ");
            }

            Console.ReadKey();
        }

        private static List<int> CombineCollections(List<int>[] collections)
        {
            List<int> combinedCollection = new();

            foreach (var numbers in collections)
            {
                foreach (var number in numbers)
                {
                    if (combinedCollection.Contains(number) == false)
                    {
                        combinedCollection.Add(number);
                    }
                }
            }

            return combinedCollection;
        }
    }
}
