using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Node<Gtype>
    {
        private string data;
        private Node<Gtype> next;
        public Node(string data)
        {
            this.data = data;
            next = null;
        }
        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        public Node<Gtype> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
