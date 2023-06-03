namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtable operation");
            CustomHashTable<int> customHash = new CustomHashTable<int>(20);
            customHash.Add(31);
            customHash.Add(17);
            customHash.Add(29);
            customHash.Add(41);
            customHash.Add(23);

            customHash.Print();

            customHash.Search(23);
            customHash.Search(17);
        }
    }
}