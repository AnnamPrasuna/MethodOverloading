using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Parent
    {
        public void Display1()
        {
            Console.WriteLine("display1 method");
        }
        public string Display1(string s)
        {
            Console.WriteLine("display1 method with one parameter");
            return s;
        }

    }
    }
