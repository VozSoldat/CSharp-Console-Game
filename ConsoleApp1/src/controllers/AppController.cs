using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;
using ConsoleApp1.src.models;
using ConsoleApp1.src.models.Character;
using ConsoleApp1.src.tools;
using ConsoleApp1.src.views;

namespace ConsoleApp1.src.controllers;
public class AppController
{
    public BedroomController? bedroomController;
    public ClosetController? closetController;
    public Character playerCharacter = new Character();
    public ApparelRegistry apparelRegistry= new ApparelRegistry();
    public CharactersRegistry charactersRegistry = new CharactersRegistry();

    // public List<Apparel> worldApparels = new List<Apparel>();
    public void Run()
    {
        charactersRegistry.PopulateRandom(20);
        apparelRegistry.LoadJsonString(File.ReadAllText("apparelJSON/apparels.json"),false);
        List<string> availableApparels = apparelRegistry.ListAvailableApparel();
        foreach (var apparel in availableApparels)
        {
            Console.WriteLine(apparel);
        }
        // bedroomController = new BedroomController(this);
        // closetController = new ClosetController(this);
        // bedroomController.Run();
    }
}


