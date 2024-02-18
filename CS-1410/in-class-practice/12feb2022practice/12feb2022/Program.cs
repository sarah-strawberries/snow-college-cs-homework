using System;
class ContactProgram
{
    public static void Main()
    {
        Contact c1 = new Contact("Jiminy Cricket", 3456467777);
        c1.PrintDetails();
        Contact c2 = new Contact("Jane Doe", 4001234567);
        c2.PrintDetails();
    }
public class Contact
{
    public static List<Contact> Contacts = new List<Contact>();
    private string name;
    private ulong phoneNumber;
    public string Name{get; private set;}
    public void PrintDetails()
    {
        Console.WriteLine("---Contact Info---");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
    }
    public void StoreContact()
    {
        //put contact in a list
        Contacts.Add(this);
    }
    ulong PhoneNumber
    {
        get
        {
            return phoneNumber;
        } 
        set
        {
            if (value > 9999999999)
            {
                throw new BadPhoneNumberException("Phone number must have no more than 10 digits.");
            }

            if (value < 2010000000)     
            {
                throw new BadPhoneNumberException("Phone number must have a valid US area code.");
            }
            phoneNumber = value;
        }
    }

    public Contact(string name, ulong number)
    {
        Name = name;
        PhoneNumber = number;
        this.StoreContact();
    }
}
}