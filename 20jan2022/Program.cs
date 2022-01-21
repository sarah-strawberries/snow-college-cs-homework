using System;

namespace DriversLicenseInfo 
{
    class Program
    {
        class DriversLicense
        {
            private string fullName;
            private int DOB;
            private char gender;
            private string eyes;
            private string hair;
            public DriversLicense(string name, int mmddyyyy, char m_f, string color1, string color2)
            {
                fullName = name;
                DOB = mmddyyyy;
                gender = m_f;
                eyes = color1;
                hair = color2;

            }
            JanesLicense = new DriversLicense(string "Jane Doe", int 01221998, char F, string "blue", string "blonde" );
        }
    }
}