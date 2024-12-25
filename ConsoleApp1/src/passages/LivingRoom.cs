using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.views;
public class LivingRoom : views.View
{
    public override void PrintOptions()
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("- Make something on the cooking spot. (1)");
        Console.WriteLine("- Go to the balcony. (2)");
        Console.WriteLine("- Go to your bedroom. (3)");
        Console.WriteLine("- Exit the apartment. (4)");
    }

    public override void PrintPassage()
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("You are in your living room.");
        Console.WriteLine("Great job! Your living room is bright and welcoming. If only your next-door could let a hand out to you occasionally.");
        Console.WriteLine("There is a couch and a table in the middle, facing to the door to balcony. A small fireplace is in the corner. A cooking spot is in the corner near exit.");
        Console.WriteLine();

        // action info
        Console.WriteLine("This room connects three bedrooms of your roommate.");
        Console.WriteLine("================================");
    }
}
