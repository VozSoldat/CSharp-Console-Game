using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.views;
public class Bedroom: View
{
    // Constructor
    public Bedroom()
    {
        // Initialize any necessary data or dependencies here
    }

    // Public method to render the initial view
    public void Render()
    {
        DisplayRoomDescription();
        PrintOptions();
    }

    // Method to display the room description
    private void DisplayRoomDescription()
    {
        Console.WriteLine("You are in a bedroom.");
        Console.WriteLine("There is a bed and a closet with a built-in mirror.");
        Console.WriteLine("");
    }

    // Method to print user options
    private void PrintOptions()
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("- Look at the bed. (1)");
        Console.WriteLine("- Look at the closet. (2)");
    }

    // Method to get the user's choice
    

    // Method to handle looking at the bed
    public void LookAtBed()
    {
        Console.WriteLine("This is your bed. It is neatly made.");
    }

    // Additional methods for future actions (e.g., LookAtCloset) can be added here
}
