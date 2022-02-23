using System;
using System.Collections.Generic;

public class pizza
{
    public List<toppings> toppingsList = new List<toppings>();

    public string Name { get; }

    public void addToppings(toppings newTopping)
    {
        if (!toppingsList.Contains(newTopping))
        {
            toppingsList.Add(newTopping);
        }
        else
        {
            throw new noRepeatingToppingsException();
        }
    }

    public void addToppings(toppings newTopping, toppings newTopping2)
    {

        toppingsList.Add(newTopping);
        toppingsList.Add(newTopping2);
    }

    public void addToppings(toppings newTopping, toppings newTopping2, toppings newTopping3)
    {
        toppingsList.Add(newTopping);
        toppingsList.Add(newTopping2);
        toppingsList.Add(newTopping3);
    }

    public void showPizza()
    {
        System.Console.WriteLine($"{this.Name}'s pizza has:");
        foreach (toppings topping in toppingsList)
        {
            Console.WriteLine(topping);
        }
        Console.WriteLine("");
    }
    public pizza(string name)
    {
        Name = name;
    }
}

public class noRepeatingToppingsException : System.Exception
{
    public noRepeatingToppingsException()
    {

    }

    public noRepeatingToppingsException(string message) :
    base(message)
    {
        System.Console.WriteLine(message);
    }

}


public enum toppings
{
    pepperoni,
    cheese,
    pineapple,
    sauce,
    onions,
    sausage,
    peppers
}

class Program
{
    public static void Main()
    {
        pizza DoriansPizza = new pizza("Dorian");
        DoriansPizza.addToppings(toppings.pepperoni, toppings.cheese, toppings.sauce);
        DoriansPizza.showPizza();

        pizza SarahsPizza = new pizza("Sarah");
        SarahsPizza.addToppings(toppings.cheese, toppings.peppers, toppings.sausage);
        SarahsPizza.showPizza();


        Console.WriteLine("Type n to make a new pizza!");
        var answer = Console.ReadLine();
        while ( answer != "n")
        {
            Console.WriteLine("Please press n if you want to make a new pizza.");
            answer = Console.ReadLine();
        if (answer != "n")
        {
            continue;
        }
        break;
        }
        Console.WriteLine("What name is this pizza under?");
        answer = Console.ReadLine();

        pizza pizza1 = new pizza(answer);
        Console.WriteLine("Pizza successfully created!");
        while (true)
        {
            Console.WriteLine("What toppings would you like to add? Press x if you don't want to add any more toppings.");
            Console.WriteLine("(Options: pepperoni, cheese, pineapple, sauce, onions, sausage, peppers)");
            System.Console.WriteLine("Please enter a topping or press x.");
            string inputTopping = Console.ReadLine().ToLower().Trim();
            try
            {
                pizza1.addToppings((toppings)Enum.Parse(typeof(toppings), inputTopping));
                Console.WriteLine("");
                pizza1.showPizza();
            }
            catch (System.ArgumentException badToppingException)
            {
                if (inputTopping == "x")
                {
                    Console.WriteLine("Thanks for making a pizza today! Enjoy your virtual eating experience!");
                    break;
                }
                Console.WriteLine("***ERROR: Invalid topping.Please choose from the list of available toppings.");
            }
            catch (noRepeatingToppingsException noRepeats)
            {
                Console.WriteLine("***ERROR: That topping is already on the pizza!");
            }
        }
    }
}

