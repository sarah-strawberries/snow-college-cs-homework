using System;
using System.Collections; //note to self: contains Hashtable and ArrayList
class MyObject
{
    //nothing interesting in here
}
class Program
{

    
    public static void Main()
    {
    ArrayList MyArrayList = new ArrayList();
    MyObject obj1 = new MyObject();
    MyObject obj2 = new MyObject();

    MyArrayList.Add(obj1);
    
    MyArrayList.Add(obj2);
    }

}