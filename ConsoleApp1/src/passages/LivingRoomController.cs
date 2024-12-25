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

        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}