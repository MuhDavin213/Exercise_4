using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    public class Stack : IEnumerable<int>
    {
        private int Davin;
        private int[] StackArray;
        private int top = -1;

        public int Count { get;{ return top + 1; } }

        public Stack(int Davin)
        {
            this.Davin = Davin;
            StackArray = new int[Davin];
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
