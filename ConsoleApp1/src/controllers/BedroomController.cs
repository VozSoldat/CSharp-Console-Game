using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.views;

namespace ConsoleApp1.src.controllers;
public class BedroomController : IController
{
    private readonly View bedroom = new Bedroom();
    readonly AppController appController = new AppController();
    private string choice;
    public BedroomController(AppController appController)
    {
        this.appController = appController;
    }
    public void Run()
    {
        while (true)
        {

            bedroom.PrintPassage();
            bedroom.PrintOptions();
            choice = bedroom.GetChoice();
            handleChoice();
        }
    }

    public void handleChoice()
    {
        switch (choice)
        {
            case "1":
                Console.WriteLine("1 selected");
                break;
            case "2":
                appController.closetController.Run();
                break;
        }
    }
}
