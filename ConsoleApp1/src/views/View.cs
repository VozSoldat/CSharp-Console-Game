using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.views;
public class View
{
    public string GetChoice()
    {
        Console.WriteLine ("*************************");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine()?.Trim();
        Console.WriteLine ("*************************");
        return choice;
    }
}
