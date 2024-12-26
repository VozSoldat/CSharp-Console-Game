using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.views;

namespace ConsoleApp1.src.controllers
{
    public class LivingRoomController : IController
    {
        public View View { get; set; } = new LivingRoom();
        public AppController AppController { get; set; }


        public string? Choice { get; set; }

        public LivingRoomController(AppController appController)
        {
            AppController = appController;
        }
        public void handleChoice()
        {
            switch (Choice)
            {
                case "1":
                    Console.WriteLine("cookingsssssssssssss");
                    break;
                case "2":
                    Console.WriteLine("balconyssssssssssssss");
                    break;
                case "3":
                    AppController.bedroomController?.Run();
                    break;
                case "4":
                    Console.WriteLine("imma keluar rumah");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.\n");
                    break;
            }
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
    }
}