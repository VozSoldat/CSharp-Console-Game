using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.models;

namespace ConsoleApp1.src.views;
public class Closet: View
{

    public override void PrintPassage()
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("This is your closet. You can find all of your clothes here.");
        Console.WriteLine();

        // action info
        Console.WriteLine("This closet is situated inside your bedroom.");
        Console.WriteLine("================================");
    }
    public override void PrintOptions()
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("- See all clothes. (1)");
        Console.WriteLine("- Step back. (2)");

    }
}
