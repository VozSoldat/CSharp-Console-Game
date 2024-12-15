using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;
using ConsoleApp1.src.models;
using ConsoleApp1.src.models.Character;
using ConsoleApp1.src.views;
using ConsoleApp1.src.interfaces;

namespace ConsoleApp1.src.controllers;
public class AppController : Controller
{
    Character playerCharacter;
    List<Apparel> apparelsInTheWorld;
    public AppController()
    {
        apparelsInTheWorld =
        [
            // 1
            new Apparel("buttoned-up shirt",ApparelSlot.Top,"white", "plain", "cotton",
            [BodyCoverage.Neck, BodyCoverage.Shoulders,BodyCoverage.UpperArms, BodyCoverage.LowerArms, BodyCoverage.UpperChest, BodyCoverage.LowerChest, BodyCoverage.Breasts, BodyCoverage.UpperTorsoSide, BodyCoverage.LowerTorsoSide, BodyCoverage.UpperAbdomen, BodyCoverage.LowerAbdomen, BodyCoverage.UpperBack, BodyCoverage.LowerBack, BodyCoverage.Hip], 
            IntegrityType.Strong),
            // 2
            new Apparel("short shorts", ApparelSlot.Leg, "black", "plain", "cotton", [BodyCoverage.Hip, BodyCoverage.LowerTorsoSide, BodyCoverage.Crotch, BodyCoverage.UpperThighs, BodyCoverage.Buttocks,BodyCoverage.Anus], IntegrityType.Strong),
        ];

        playerCharacter = 
            // CharacterCreation.PlayerCharacterCreation();
            new Character(Guid.NewGuid(), "Jane", "Doe", SexType.Feminime, 19, 2, 3);
    }

    public override void Run()
    {
        while (true)
        {

            Menu menu = new Menu();
            if (!menu.OnChooseStart)
            {
                return;
            }
            

            IBedroomController bedroomController = new BedroomController(playerCharacter, apparelsInTheWorld);
            bedroomController.Run();
        }
    }
}
