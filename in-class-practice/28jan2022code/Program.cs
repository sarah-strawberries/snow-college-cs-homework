using System;

namespace PracticeFuzzies
{
    internal class Program //what does internal do?
    {
        static void Main()
        {

        }

        public interface IProduct
        {
            string Name { get; set; }
            // propfull gives you the below:
            //private int myVar;
            // public int MyProperty
            bool Inspect();

        }
        public abstract class Toy : IProduct
        {
            string IProduct.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            Console.WriteLine("\tIn the Toy ctor");
            bool IProduct.Inspect()
            {
                if (MinAge < 3)
                {
                    return false;
                }
                return true;
            }
            private int MinAge;
        }
        public class Dradle : Toy
        {
            public Dradle(int minAge)
            {
                MinAge = minAge;
            }
        }
        public class Lego : Toy
        {
            public Dradle(int minAge)
            {
                MinAge = minAge;
            }
        }
        public class Technic : Lego
        {
            public Technic(int minAge) : base(minAge)
            {
                Console.WriteLine("\tIn the Toy ctor");
            }
        }

        public class TekDek : Toy 
        {

        }
    }
}

// static void Main(string[] args)
// {
//     var products = new List<IProduct>();
//     products.Add(new Dradle(5));
//     foreach (var p in products)
//     {
//         Console.WriteLine("{0} Passes inspection? {1}",
//     name.ToString(),
//     name.Inspect());
//     }
// }

//base means immediate parent class
/*
Concepts to review:
-overloading
-overriding
-exceptions
-ToString
-that funky conditional in the commented-out code above
-var (uses for it)
-Debugging!!!



*/