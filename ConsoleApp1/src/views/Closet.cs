using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.views;
public class Closet
{
    public Closet()
    {

    }
    public void Render()
    {
        Console.WriteLine("You can see your collection of clothes.");
        Console.WriteLine("");

        Console.WriteLine("- Change clothes (1)");
        Console.WriteLine("- Go back (2)");
    }

    public string GetChoice()
    {
        while (true)
        {
            string choice = Console.ReadLine();
            return choice;
        }
    }

    
}
