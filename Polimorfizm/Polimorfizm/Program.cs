using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_virtual_new
{
    class A
    {
        public virtual void show()
        {
            Console.WriteLine("Hello: Base Class!");
            Console.ReadLine();
        }
    }
    class B : A
    {
        public override void show()
        {
            Console.WriteLine("Hello: Derived Class!");
            Console.ReadLine();
        }
    }

    class C : B
    {
        public new void show()
        {
            Console.WriteLine("Am Here!");
            Console.ReadLine();
        }
    }
    class D : C
    {
        public void show()
        {
            Console.WriteLine("It is method of D");
            Console.ReadLine();
        }
    }
    class E : B
    {
        public override void show()
        {
            Console.WriteLine("This is method of E");
            Console.ReadLine();
        }
    }
    class Polymorphism
    {
        public static void Main()
        {
            A a1 = new A();
            a1.show();
            B b1 = new B();
            b1.show();
            C c1 = new C();
            c1.show();
            A a2 = new B();
            a2.show();
            A a3 = new C();
            a3.show();
            B b3 = new C();
            b3.show();
            D d1 = new D();
            d1.show();
            B d2 = new D();
            d2.show();
            C d3 = new D();
            d3.show();
            E e1 = new E();
            e1.show();
        }
    }
}
