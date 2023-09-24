using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public interface Inter1 {
        void m1();
    }
    public interface Inter2
    {
        void m1();
    }

    public class c1
    {
        public void func()
        {
            Console.WriteLine("this is Parent Class");
        }
    }
    public class c2:c1, Inter1,Inter2
    {
        void  Inter1.m1()    //Expcilit Interface Implimantion
        {
            Console.WriteLine("this is Interface1");
        }
        void Inter2.m1()
        {
            Console.WriteLine("this is Interfac2");
        }


    }
    delegate void d1(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            
            {

            }
            Inter1 obj = new c2(); //object creation of Interface
            
            
            Inter2 obj1 = new c2();

            obj.m1();  //calling Explicit Interface
            obj1.m1();
            
            Console.ReadKey();
        }
    }
}
