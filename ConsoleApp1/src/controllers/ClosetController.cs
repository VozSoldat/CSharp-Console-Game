using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.views;

namespace ConsoleApp1.src.controllers;

public class ClosetController:IController
{
    View view = new Closet ();
    IController bedroomController;
    private string choice;

    public ClosetController() { }
    public ClosetController(IController bedroomController)
    {
        this.bedroomController = bedroomController;
    }    
    public void Run()
    {
        view.PrintPassage();
        view.PrintOptions();
        choice = view.GetChoice();
        handleChoice();
    }
    public void handleChoice()
    {
        switch (choice)
        {
            case "1":
                Console.WriteLine("Clotheeeeeeeeeeeeeeeees");
                break;
            case "2":
                bedroomController.Run();
                break;

            
        }
    }
}
