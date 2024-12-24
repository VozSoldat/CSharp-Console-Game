using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.views;

namespace ConsoleApp1.src.controllers;

public class ClosetController : IController
{
    View view = new Closet();
    readonly AppController appController = new AppController();
    private string choice;

    public ClosetController(AppController appController)
    {
        this.appController = appController;
    }
    public void Run()
    {
        while (true)
        {
            view.PrintPassage();
            view.PrintOptions();
            choice = view.GetChoice();
            handleChoice();
        }
    }
    public void handleChoice()
    {
        switch (choice)
        {
            case "1":
                Console.WriteLine("Clotheeeeeeeeeeeeeeeees");
                break;
            case "2":
                appController.bedroomController.Run();
                break;


        }
    }
}
