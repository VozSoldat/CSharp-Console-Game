using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.views;
public class Bedroom: View
{
    // Constructor
    public Bedroom(IController controller)
    {
        this.controller = controller;
    }
    public override void PrintPassage()
    {

    }

    // Method to print user options
    public override void PrintOptions()
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("- Look at the bed. (1)");
        Console.WriteLine("- Look at the closet. (2)");
    }
}
