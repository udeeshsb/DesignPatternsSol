using System;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is singleton design pattern");
            //Thread safety singleton pattern
            Parallel.Invoke(
                () => FirstMethod(),
                () => SecondMethod()
            );

            Console.WriteLine("--Non Singleton--");
            //Logger obj1 = new Logger(); //its giving an error due to restriction of singleton
            Testing obj3 = new Testing();
            Testing obj4 = new Testing();
            Console.WriteLine(obj3.GetHashCode());
            Console.WriteLine(obj4.GetHashCode());


            //Console.WriteLine("--Sealed Example Singleton--");
            //Logger.ChildLogger objChild = new Logger.ChildLogger();
            //objChild.PrintDetails();
        }

        private static void SecondMethod()
        {
            Console.WriteLine("--SecondMethod Singleton--");
            //Logger obj1 = new Logger(); //its giving an error due to restriction of singleton
            Logger obj5 = Logger.GetInstance;
            Logger obj6 = Logger.GetInstance;
            Console.WriteLine(obj5.GetHashCode()); //Hashcode will be same for both the objects
            Console.WriteLine(obj6.GetHashCode());
        }

        private static void FirstMethod()
        {
            Console.WriteLine("--FirstMethod Singleton--");
            //Logger obj1 = new Logger(); //its giving an error due to restriction of singleton
            Logger obj1 = Logger.GetInstance;
            Logger obj2 = Logger.GetInstance;
            Console.WriteLine(obj1.GetHashCode()); //Hashcode will be same for both the objects
            Console.WriteLine(obj1.GetHashCode());
        }
    }

    /// <summary>
    /// singleton class -- Objects used for logging, device drivers (like printer object) or registry settings need to 
    /// have only one of a kind of object for all the references.
    /// Real world usages
    /// 1. Logging
    /// 2. Managing a connection or a pool of connections to DB
    /// 3. Printer spooling
    /// 4. File
    /// 5. Configuration
    /// 6. Cache
    /// 7. Session based shopping cart
    /// </summary> 


    //public class Logger
    //Sealed restricts the inheritane of the class (we can create a class inside the Logger class - to avoid we are using sealed)
    public sealed class Logger
    {
        private static int counter = 0;

        //Normal singleton initialization
        private static Logger instance = null;

        ////Eager initialization
        //private static readonly Logger instance = new Logger();  //Thread safety is automatically taken care by CLR 

        ////Lazy initialization/Loading
        //private static readonly Lazy<Logger> instance = new Lazy<Logger>(() => new Logger());  //By default Lazy is Thread safe 

        private static readonly object obj = new object(); //to craete Thread safety singleton 

        /// <summary>
        /// private constructor ensures that object is not instantiated other than with in the class itself
        /// </summary>
        private Logger()
        {
            counter++;
            Console.WriteLine("Logger Objection creation: " + counter.ToString());
        }

        /// <summary>
        /// public property is used to return only one instance of the class leveraging (use (something) to maximum advantage)
        /// on the private property
        /// </summary>
        public static Logger GetInstance
        {
            //Normal singleton initialization
            get
            {
                if (instance == null) //Double checking lock
                {
                    lock (obj) //Lock are very expensive we are using above if condition
                    {
                        if (instance == null)
                            instance = new Logger();
                    }
                }
                return instance;
            }


            ////Eager initialization
            //get
            //{ 
            //    return instance;
            //}

            ////Lazy initialization
            //get
            //{
            //    return instance.Value;
            //}
        }

        public void PrintDetails()
        {
            Console.WriteLine("PrintDetails Method: " + counter.ToString());
        }

        //public class ChildLogger : Logger
        //{

        //}
    }


    //non singleton
    public class Testing
    {
        private static int counter = 0;
        public Testing()
        {
            counter++;
            Console.WriteLine("Testing Objection creation: " + counter.ToString());
        }
    }
}
