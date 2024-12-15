using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.views;
public class Menu
{
    private string? choice;
    private bool onChooseStart;
    public Menu()
    {
        Render();
    }
    private void Render()
    {
        Console.WriteLine("==============================");
        Console.WriteLine("W E L C O M E  T O  A  G A M E");
        Console.WriteLine("==============================");
        Console.WriteLine("");

        Console.WriteLine("MAIN MENU");
        Console.WriteLine("=========");
        Console.WriteLine("- Start game (1)");
        Console.WriteLine("- Exit (2)");

        choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                onChooseStart = true;
                break;
            case "2":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid input. Please choose a valid option (1 or 2): ");
                Render();
                break;
        }
    }

    public bool OnChooseStart => onChooseStart;
}
