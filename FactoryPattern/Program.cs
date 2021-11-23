using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ClassA Objects!");
            ClassA aObj = new ClassA();
            aObj.MethodA();

            Console.WriteLine("\nClassB Objects! ");
            ClassB bObj = new ClassB();
            bObj.MethodA();
            bObj.MethodB();

            Console.WriteLine("\nClassA or ClassB Objects! ");
            //Superclass obj = new Subclass();
            int x = 10;
            ClassA aObj1 = new ClassB();
            aObj1.MethodA();
            //aObj1.MethodB(); //MethodB() cannot access the propert type of ClassA
            ((ClassB)aObj1).MethodB(); //casting the object in normayl way
            (aObj1 as ClassB).MethodB(); //casting the object using "as" keyword


            Console.WriteLine("\nInterfaceA Objects! ");
            InterfaceA aInterfaceObj1 = new ClassInterfaceB();
            aInterfaceObj1.MethodA();
            aInterfaceObj1.MethodB();
            //cannot do this
            //ClassB bObj1 = new ClassA();

        }
    }

    public interface InterfaceA
    {
        void MethodA();
        void MethodB();
    }

    public class ClassInterfaceB : InterfaceA
    {
        public void MethodA()
        {
            Console.WriteLine("InterfaceA - Method A");
        }

        public void MethodB()
        {
            Console.WriteLine("InterfaceA - Method B");
        }
    }

    public class ClassA
    {
        public virtual void MethodA()
        {
            Console.WriteLine("ClassA - Method A");
        }
    }

    public class ClassB : ClassA
    {
        public override void MethodA()
        {
            Console.WriteLine("ClassB - Method A");
        }

        public void MethodB()
        {
            Console.WriteLine("ClassB - Method B");
        }
    }
}
