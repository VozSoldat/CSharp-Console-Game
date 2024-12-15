using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.interfaces;
using ConsoleApp1.src.models.Character;
using ConsoleApp1.src.views;

namespace ConsoleApp1.src.controllers;
public class BedroomController : Controller, IBedroomController
{
    public Bedroom bedroom{ get; set; }
    public Closet closet{ get; set; }
    public Character playerCharacter{ get; set; }
    public BedroomController(Character character)
    {
        bedroom = new Bedroom();
        closet = new Closet();
        playerCharacter = character;
    }

    public override void Run()
    {
        while (true)
        {
            Console.Clear();
            bedroom.Render();
            bedroom.PrintOptions();
            string choice = bedroom.GetChoice();
            if (choice == "1") bedroom.LookAtBed();
            if (choice == "2")
            {
                ManageCloset();
            }
        }
    }

    private void ManageCloset()
    {
        while (true)
        {
            Console.Clear();
            closet.Render();
            string choice = closet.GetChoice();
            if (choice == "1")
            {

            }
            else if (choice == "2") break;
        }
    }
}
