using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.models;
using ConsoleApp1.src.models.Character;
using ConsoleApp1.src.views;

namespace ConsoleApp1.src.interfaces;
public interface IBedroomController
{
    Bedroom bedroom{ get; set; }
    Closet closet{ get; set; }
    Character playerCharacter{ get; set; }
    List<Apparel> apparelsInTheWorld{ get; set; }

    void Run();
}
