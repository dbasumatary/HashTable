namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtable operation");
            CustomHashTable<string> customHash = new CustomHashTable<string>(10);
            customHash.Add("Bob");
            customHash.Add("Max");
            customHash.Add("John");
            customHash.Add("Peter");

            customHash.Print();

            customHash.Search("Bob");
            customHash.Search("Jack");

            customHash.Delete("Peter");
            Console.WriteLine();
            customHash.Print();
        }
    }
}