using System;

namespace HashTableImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------Hash Table-----------------------");
            string sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
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
