using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class DataStructure<Gtype>
    {
        private Node<Gtype> head;
        private int count;
        public DataStructure()
        {
            this.head = null;
            this.count = 0;
        }
        public bool Empty
        {
            get { return this.count == 0; }
        }
        public int Count
        {
            get { return this.count; }
        }
        public string AddPosition(int index, string d)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException($"Index:{index}");
            }
            if (index > count)
            {
                index = count;
            }
            Node<Gtype> current = this.head;
            if (this.Empty || index == 0)
            {
                this.head = new Node<Gtype>(d, this.head);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = new Node<Gtype>(d, current.Next);
            }
            count++;
            return d;
        }
        public string Add(string d)
        {
            return this.AddPosition(count, d);
        }
        public bool Search(string val)
        {
            Node<Gtype> current = this.head;
            for (int i = 0; i < count; i++)
            {
                if (current.Data.Equals(val))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public void Show()
        {
            Node<Gtype> current = this.head;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
        public string Remove(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException($"Index:{index}");
            }
            if (this.Empty)
                return "";

            if (index >= this.count)
            {
                Console.WriteLine($"Can not Delete by {index} Index");
            }
            Node<Gtype> current = this.head;
            string result = "";
            if (index == 0)
            {
                result = current.Data;
                this.head = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.Next;
                result = current.Next.Data;

                current.Next = current.Next.Next;
            }
            count--;
            return result;
        }
        public string RemoveData(string word)
        {
            Node<Gtype> current = this.head;
            int index = 0;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(current.Data);
                if (current.Data == word)
                {
                    index = i;
                }
                current = current.Next;
            }
            return Remove(index);
        }
    }
}
