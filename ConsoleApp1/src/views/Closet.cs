using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.models;

namespace ConsoleApp1.src.views;
public class Closet: View
{
    public Closet(IController controller)
    {
        this.controller = controller;
    }

    public override void PrintOptions()
    {
        Console.WriteLine("What do you want to do?");

    }

    public override void PrintPassage()
    {
        throw new NotImplementedException();
    }
}
