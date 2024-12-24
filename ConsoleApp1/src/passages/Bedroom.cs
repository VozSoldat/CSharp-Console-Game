using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.models;

namespace ConsoleApp1.src.views;
public class Bedroom: View
{
    // Constructor

    public override void PrintPassage()
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("You are in your bedroom.");
        Console.WriteLine("Great job! Your bedroom is fragrant and comfortable. You prove that such a humble abode is capable to be a sanctuary.");
        Console.WriteLine();

        // action info
        Console.WriteLine("There are a bed and a closet.");
        Console.WriteLine("================================");
    }

    // Method to print user options
    public override void PrintOptions()
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("- Look at the bed. (1)");
        Console.WriteLine("- Look at the closet. (2)");
    }
}
