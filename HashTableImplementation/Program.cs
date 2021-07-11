using System;

namespace HashTableImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------Hash Table-----------------------");
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = paragraph.Split(' ');
            MyMapNode<int, string> hashTable = new MyMapNode<int, string>(words.Length);
            int key = 0;
            foreach(string word in words)
            {
                hashTable.Add(key, word);
                key++;
            }
            Console.WriteLine();
            Operation operation = new Operation();
            operation.Frequency(hashTable);
            Console.WriteLine();
            operation.Remove(hashTable, "avoidable");
        }
    }
}
