using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class CustomHashTable<T>
    {
        private class Node
        {
            public T Data;
            public Node Next;

            public Node(T data)
            {
                Data = data;
            }
        }

        private Node[] Names;
        
        public CustomHashTable(int size)
        {
            Names = new Node[size];
        }

        //Add method 
        public void Add(T name)
        {
            Node newNode = new Node(name);
            int arrayIndex = Math.Abs(name.GetHashCode()) % Names.Length; //Number between 0 to size of array
            Names[arrayIndex] = newNode;
        }

        //Display method
        public void Print()
        {
            for (int index = 0; index < Names.Length; index++)
            {
                Node temp = Names[index];

                Console.Write($"Index {index} : ");
                while (temp != null)
                {
                    Console.Write(temp.Data + " -> ");
                    temp = temp.Next;
                }
                Console.WriteLine();
            }
        }

        //Search method
        public void Search(T name)
        {
            int arrayIndex = Math.Abs(name.GetHashCode()) % Names.Length;
            Node temp = Names[arrayIndex];

            if (temp == null)
            {
                Console.WriteLine($"{name} not found");
                return;
            }

            while (!temp.Data.Equals(name))
            {
                if (temp.Next == null)
                {
                    Console.WriteLine($"{name} not found");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine($"{name} is present at {arrayIndex} index in the hashtable");
        }
    }
}
