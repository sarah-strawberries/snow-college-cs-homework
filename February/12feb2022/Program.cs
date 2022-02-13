using System;

class Contact
{
    string Name{get; set;}
    ulong PhoneNumber{get
    {} 
    set
    {
        if (value !< 99999999990)
        {throw new BadPhoneNumberExeption;
        }
                }
    }

    public Contact(string name, ulong number)
    {
        Name = name;
        PhoneNumber = number;
    }
}