using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.views;

namespace ConsoleApp1.src.controllers;

public class ClosetController : IController
{
    public View View { get; set; } = new Closet();
    public AppController AppController { get; set; }


    public string? Choice { get; set; }

    public ClosetController(AppController appController)
    {
        AppController = appController;
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
                Console.WriteLine("Clotheeeeeeeeeeeeeeeees");
                break;
            case "2":
                AppController.bedroomController?.Run();
                break;


        }
    }
}
