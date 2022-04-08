using System;
using System.Collections;

public class Program
{
    public Hashtable table1 = new Hashtable();
    public void AddStuffAndDoStuff()
    {
        table1.Add("key", new Cow());
        Cow retrievedCow = table1[0] as Cow;
        retrievedCow.Moo();
    }


    public class Cow
    {
        public void Moo()
        {
            Console.WriteLine("Moo");
        }
    }
    public static void Main()
    {
        Program p = new Program();
        p.AddStuffAndDoStuff();
    }
}
