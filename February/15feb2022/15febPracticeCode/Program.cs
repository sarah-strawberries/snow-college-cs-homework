using System;

public class MyPerson
{
    public MyPerson(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public MyPerson()
    {
        name = "Fred";
        age = 97;
    }
    string name;
    int age;
    public static bool StoreMyPersonsInfo(MyPerson person)
    {
        //do stuff that makes the MyPerson object get saved, probably using a stream
        System.IO.TextWriter writeText = null;
        try 
        {
            writeText = new System.IO.StreamWriter(@"C:\Users\Allen\code\homeworkpractice-sarah-strawberries\February\15feb2022\myFile.txt");
            writeText.WriteLine(person.GetType());
            writeText.WriteLine(person.name);
            writeText.WriteLine(person.age);
        }
        catch
        {
            return false;
        }
        finally 
        {
            if (writeText != null)
            {
                writeText.Close();
            }
        }
        return true;
        
    }

    public static MyPerson LoadPersonFromFile()
    {
        MyPerson retrievedPerson = new MyPerson();
        System.IO.TextReader readText = null;
        try
        {
            readText = new System.IO.StreamReader(@"C:\Users\Allen\code\homeworkpractice-sarah-strawberries\February\15feb2022\myFile.txt");
            string objectType = readText.ReadLine();
            string nameText = readText.ReadLine();
            int ageInt = int.Parse(readText.ReadLine());
            if (objectType == "MyPerson")
            {
                retrievedPerson.name = nameText;
                retrievedPerson.age = ageInt;
                
            }
        }
        catch
        {
            return null;
        }
        return retrievedPerson as MyPerson;
        readText.Close();
    }

 public static void Main()
 {
     MyPerson testPerson = new MyPerson("Minnie Mouse", 93);
     MyPerson.StoreMyPersonsInfo(testPerson);
     MyPerson retrievedTestPerson = MyPerson.LoadPersonFromFile();
     Console.WriteLine("Person Details:");
     Console.WriteLine($"Name: {retrievedTestPerson.name}");
     Console.WriteLine($"Age: {retrievedTestPerson.age}");
 }


}



