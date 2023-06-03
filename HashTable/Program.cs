namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtable operation");
            CustomHashTable<int> customHash = new CustomHashTable<int>(10);
            customHash.Add(31);
            customHash.Add(12);
            customHash.Add(29);
            customHash.Add(41);
            customHash.Add(23);

        }
    }
}