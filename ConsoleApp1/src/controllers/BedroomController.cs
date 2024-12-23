using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.views;

namespace ConsoleApp1.src.controllers;
public class BedroomController : IController
{
    private readonly View bedroom;
    readonly IController closetController;
    private string choice;
    public BedroomController(View bedroom, IController closetController)
    {
        this.bedroom = bedroom;
        this.closetController = closetController;
    }
    public void Run()
    {
        bedroom.PrintPassage();
        bedroom.PrintOptions();
        choice = bedroom.GetChoice();
        handleChoice();
    }

    public void handleChoice()
    {
        switch (choice)
        {
            case "1":
                Console.WriteLine("1 selected");
                break;
            case "2":
                closetController.Run();
                break;
        }
    }
}
