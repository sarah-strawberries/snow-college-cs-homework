using System;

namespace homework_practice
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            struct PuppyLife
            {
                 public string puppyName;
                 int puppyAgeInMonths;
                public bool puppyHungry;

}
            class PuppyLifeStructureArray{
                public static void Main()
                {
                    PuppyLife[] Life = new PuppyLife[10];
                    Life[0].puppyName = Console.ReadLine("Name your puppy:");
                    Life[0].puppyHungry = true;
                }
            }
        }
    }
    
}
    