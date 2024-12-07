// See https://aka.ms/new-console-template for more information
using ConsoleApp1.src.machine;
using ConsoleApp1.src.models;
using ConsoleApp1.src.models.Character;
namespace ConsoleApp1.src;

static public class Program
{


    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Character playerCharacter = CharacterCreation.PlayerCharacterCreation();

        Console.WriteLine(playerCharacter.ID);
        Console.WriteLine(playerCharacter.Surname);
        Console.WriteLine(playerCharacter.Forename);
        Console.WriteLine(playerCharacter.SexType);
        Console.WriteLine(playerCharacter.DescribeCharacterInOneString());

        playerCharacter.WriteIntoJSONFile();

        playerCharacter.EquipApparel(new Apparel("pant", ApparelSlot.Leg, "red", "stripes", "cotton", new List<BodyCoverage> { BodyCoverage.Crotch}));
        Console.WriteLine(playerCharacter.PrintCoveredBodyPart());

    }


}
