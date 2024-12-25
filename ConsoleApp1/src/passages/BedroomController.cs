using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.views;

namespace ConsoleApp1.src.controllers;
public class BedroomController : IController
{
    public View View { get; set; } = new Bedroom();
    public AppController AppController { get; set; }


    public string? Choice { get; set; }


    public BedroomController(AppController appController)
    {
        this.AppController = appController;
    }
    public void Run()
    {
        while (true)
        {

            View.PrintPassage();
            View.PrintOptions();
            Choice = View.GetChoice();
            handleChoice();
        }
    }

    public void handleChoice()
    {
        switch (Choice)
        {
            case "1":
                Console.WriteLine("1 selected");
                break;
            case "2":
                AppController.closetController?.Run();
                break;
        }
    }
}
