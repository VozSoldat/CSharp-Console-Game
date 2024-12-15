using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.models;

namespace ConsoleApp1.src.views;
public class Closet: View
{
    public Closet()
    {

    }
    public void Render()
    {
        Console.WriteLine("You can see your collection of clothes here.");
        Console.WriteLine("");

        Console.WriteLine("- See your clothes (1)");
        Console.WriteLine("- Go back (2)");
    }

    public void ClosetView(List<Apparel> apparelsInTheWorld)
    {
        Console.Clear();
        Console.WriteLine("======================");
        Console.WriteLine("Your apparels:");
        int i = 1;
        foreach (var item in apparelsInTheWorld)
        {
            Console.Write("" + i++ +"   ");
            Console.WriteLine("" + item.GetLongName());
            Console.WriteLine();
        }

        Console.WriteLine("");
        Console.WriteLine("That's all for now.");
        

    }

    
}
