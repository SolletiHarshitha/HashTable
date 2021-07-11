using System;

namespace HashTableImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------Hash Table-----------------------");
            MyMapNode<int, string> hashTable = new MyMapNode<int, string>(6);
            hashTable.Add(0, "To");
            hashTable.Add(1, "be");
            hashTable.Add(2, "or");
            hashTable.Add(3, "not");
            hashTable.Add(4, "to");
            hashTable.Add(5, "be");
        }
    }
}
