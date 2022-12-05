using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class node
    {
        public int Davin;
        public node next;
        public node(int i, node n)
        {
            Davin = i;
            next = n;
        }
    }
    class Stack
    {
        node top;
        public Stack()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void push(int element)
        {
            node fresh;
            fresh = new node(element, null);
            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + "pushed")
        }
        public void pop()
        {
            Console.WriteLine("The poped elements is:" + top.info);
            top = top.next;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
