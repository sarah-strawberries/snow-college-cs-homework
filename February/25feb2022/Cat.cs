public partial class HomeworkPracticeProgram
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