using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class MethodOveriding
    {
        public virtual void GetMethod()
        {
            Console.WriteLine("super class Implementation");
        }
        public void GetData()
        {
            Console.WriteLine("get data from the superclass");
        }
    }
    class ChildClass : MethodOveriding
    {
        public override void GetMethod()
        {
            Console.WriteLine("child class Implementation");
        }
        /*public new void GetData()
        {
            Console.WriteLine("get data from the childclass");
        }*/
    }
    class Superchild : ChildClass
    {
        public override void GetMethod()
        {
         Console.WriteLine("super child implemented");
            
        }
        public new void GetData(int i)
        {
            Console.WriteLine("getdata method in super child class"+i);
        }
        public void ParentMethod1()
        {
          base.GetMethod();
        }
        public void ParentMethod2()
        {
            base.GetData();
        }

        public static void Main(string[] args) 
        {
            /*MethodOveriding m1 = new MethodOveriding();
            m1.GetMethod();
            m1.GetData();*/
            Superchild cl=new Superchild();
            cl.ParentMethod1();
            cl.ParentMethod2();
             cl.GetMethod();
            cl.GetData(78);
            Console.ReadLine();
        }
    }
}
