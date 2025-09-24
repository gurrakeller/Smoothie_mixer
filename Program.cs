using System.Globalization;
using System.Text.RegularExpressions;

namespace smoothie_byggaren;

class Program
{
    static void Main(string[] args)
    {
        string baseChoice = "";
        //opening dialogue + choosing optional fruit
        Console.WriteLine("Welcome dear customer to Northrend Smoothies!");
        Thread.Sleep(3000);
        Console.Clear();
        Console.Write("Please select a fruit for your smooothie! > ");
        string OptionalFruit = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Great, now what base would you like for your smoothie? \n 1. Milk \n 2. Water \n 3. Yoghurt");
        baseChoice = Console.ReadLine();
        
        
        //converting the corresponding number to the base material
        while (baseChoice != "1" && baseChoice != "2" && baseChoice != "3")
        {
            Console.Clear();
            Console.WriteLine("Please choose one of the base items by typing 1, 2 or 3:");
            Console.WriteLine("1. Milk\n2. Water\n3. Yoghurt");
            baseChoice = Console.ReadLine()?.Trim();
        }

        string SmoothieBase = baseChoice switch
        {
            "1" => "Milk",
            "2" => "Water",
            "3" => "Yoghurt",
            _ => "Unknown"
        };
        
        
        
        //picking smoothie size
        Console.Clear();
        Console.WriteLine($"Great you have selected {SmoothieBase} for your base!");
        Thread.Sleep(3000);
        Console.Clear();
        Console.Write("Last but not least please select a size for your smoothie! S/M/L > ");
        string Size = Console.ReadLine().Trim().ToUpper();
        Console.Clear();
        
        //just some very simple error management
        
        while (Size != "S" && Size != "M" && Size != "L")
        {
            Console.WriteLine("Please choose the size of your smoothie by typing S, M or L > ");
            Size = Console.ReadLine().Trim().ToUpper();
        }
        
        //creating a object for the order
        
        Smoothie smoothie1 = new Smoothie(SmoothieBase, OptionalFruit, Size);
        
        Console.Clear();
        Console.WriteLine($"Confirm your order:\n{smoothie1} \nPrice: 2,50$");
    }
}