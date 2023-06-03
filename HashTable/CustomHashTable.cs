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
    }
}
