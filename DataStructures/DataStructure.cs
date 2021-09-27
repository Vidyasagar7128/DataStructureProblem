using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructures
{
    class DataStructure<Gtype>
    {
        private Node<Gtype> top;
        public DataStructure()
        {
            this.top = null;
        }
        internal void Push(string d)
        {
            Node<Gtype> node = new Node<Gtype>(d);
            if (this.top == null)
                node.Next = null;
            else
                node.Next = this.top;
            this.top = node;
            Console.WriteLine($"data : {d}");
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Empty Stack");
            }
            Console.WriteLine($"{this.top.Data} :is Poped");
            this.top = this.top.Next;
        }
        public int Show()
        {
            int count = 0;
            Node<Gtype> temp = this.top;
            while (temp != null)
            {
                temp = temp.Next;
                count++;
            }
            return count;
        }
    }
}
