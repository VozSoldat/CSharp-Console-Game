using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.views;
public class Bedroom
{
    public Bedroom()
    {
        
    }
    public void Render()
    {
        Console.WriteLine("You are in a bedroom.");
        Console.WriteLine("There is a bed and a closet with built-in mirror.");
        Console.WriteLine("");

        
    }

    public void PrintOptions()
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("- Look at the bed. (1)");
        Console.WriteLine("- Look at the closet. (2)");
    }

    public string GetChoice()
    {
        string choice = Console.ReadLine();
        return choice;
    }

    public void LookAtBed()
    {
        Console.WriteLine("This is your bed. It is neatly made.");
    }
}
