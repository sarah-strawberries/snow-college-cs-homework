namespace test
{
    public class Cat
        {
            public string Name { get; private set; }
            public void Meow()
            {
                Console.WriteLine($"{Name}: Meow!");
            }

            public Cat(string name)
            {
                Name = name;
            }
        }

}

