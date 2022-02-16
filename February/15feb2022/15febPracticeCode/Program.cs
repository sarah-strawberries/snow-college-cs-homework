using System;

class MyPerson
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
    public bool StoreMyPersonsInfo()
    {
        //do stuff that makes the MyPerson object get saved, probably using a stream
        // var myFile = new System.IO.StreamWriter(myFile);
        // return false;
    }
}

