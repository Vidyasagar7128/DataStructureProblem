using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class DataStructure<Gtype>
    {
        Node<Gtype> forword;
        Node<Gtype> backword;
        int size;
        public DataStructure()
        {
            this.forword = null;
            this.backword = null;
            size = 0;
        }
        internal void Enqueue(string val)
        {
            string reverse = "";
            for (int i = val.Length - 1; i >= 0; i--)
            {
                reverse = reverse + val[i];
            }
            Console.WriteLine($"{val} : {reverse}");
            Node<Gtype> node = new Node<Gtype>(val);
            Node<Gtype> node1 = new Node<Gtype>(reverse);
            if (this.backword == null)
            {
                this.forword = node1;
                this.backword = node;
            }
            else
            {
                this.backword.Next = node;
                this.forword = node1;
            }
            Console.WriteLine(val);
            size++;
        }
        public int Size
        {
            get { return size; }
        }
        public bool IsEmpty()
        {
            if (size == 0)
                return true;
            return false;
        }
        public void MatchResult()
        {
            if(this.backword.Data == this.forword.Data)
                Console.WriteLine($"{this.backword.Data}:{this.forword.Data} are Equals");
            else
                Console.WriteLine($"{this.forword.Data}:{this.backword.Data} are not Equals");
        }
    }
}
