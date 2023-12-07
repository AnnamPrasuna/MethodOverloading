using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program:Parent
    {
       
        public void Display1(int i,double j) {
            Console.WriteLine("display1 method with two parameters");
        }
        public void Display1(int i, double j,double k)
        {
            Console.WriteLine("display1 method with three parameters");
        }
        static void Main(string[] args)
        {
            Program p1=new Program();
            p1.Display1();
            String s1=p1.Display1("prasuna");
            Console.WriteLine(s1);
            p1.Display1(90, 67.8);
            p1.Display1(78, 45.9, 12.9);
            Console.ReadLine();
            
        }
    }
}
