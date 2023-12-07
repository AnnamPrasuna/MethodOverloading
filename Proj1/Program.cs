using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    class A
    {
        public virtual int Add(int a, int b)
        {
            return a + b;
        }
        public int AddHello(int a, int b)
        {
            return a + b;
        }
    }
    class B : A
    {
        public override int  Add(int a, int b)//method overloading
        {
            return a - b;
        }
        public  new string AddHello(string a, string b)//method hiding
        {
            return a + b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            int k = b.Add(1, 2);
            Console.WriteLine(k);
            string d = b.AddHello("prasuna","annam");
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
