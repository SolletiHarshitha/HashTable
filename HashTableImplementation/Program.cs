using System;

namespace HashTableImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------Hash Table-----------------------");
            string sentence = "To be or not to be";
            string[] words = sentence.Split(' ');
            MyMapNode<int, string> hashTable = new MyMapNode<int, string>(words.Length);
            int key = 0;
            foreach(string word in words)
            {
                hashTable.Add(key, word);
                key++;
            }
       
            Operation operation = new Operation();
            operation.Frequency(hashTable);
        }
    }
}
