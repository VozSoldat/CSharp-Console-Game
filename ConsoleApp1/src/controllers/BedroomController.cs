using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.interfaces;
using ConsoleApp1.src.models;
using ConsoleApp1.src.models.Character;
using ConsoleApp1.src.views;

namespace ConsoleApp1.src.controllers;
public class BedroomController : Controller, IBedroomController
{
    public Bedroom bedroom { get; set; }
    public Closet closet { get; set; }
    public Character playerCharacter { get; set; }
    public List<Apparel> apparelsInTheWorld { get; set; }

    public BedroomController(Character character, List<Apparel> apparelsInTheWorld)
    {
        bedroom = new Bedroom();
        closet = new Closet();
        playerCharacter = character;
        this.apparelsInTheWorld = apparelsInTheWorld;
    }

    public override void Run()
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine("\n\n");
            bedroom.Render();
            string choice = bedroom.GetChoice();
            if (choice == "1") bedroom.LookAtBed();
            else if (choice == "2") ManageCloset();
        }
    }

    private void ManageCloset()
    {
        Console.Clear();
        while (true)
        {
            closet.Render();
            string choice = closet.GetChoice();
            if (choice == "1")
            {
                closet.ClosetView(apparelsInTheWorld);
            }
            else if (choice == "2") break;
        }
    }
}
