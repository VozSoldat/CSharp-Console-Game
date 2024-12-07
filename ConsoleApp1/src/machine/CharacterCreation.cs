using System;
using System.Security.Cryptography;
using ConsoleApp1.src.models.Character;

namespace ConsoleApp1.src.machine;
public static class CharacterCreation
{
    public static Character PlayerCharacterCreation()
    {
        Console.WriteLine("Insert your name.");
        Console.WriteLine("==================");
        string surname = SurnameInput();

        Console.WriteLine("");

        string forename = ForenameInput();

        Console.WriteLine("");

        SexType sexType = InputSexType();

        Console.WriteLine("");

        // Age input with validation
        int age = InputAge();

        Console.WriteLine("");

        // Physique declaration
        short[] physique = InputPhysique();
        short fat = physique[0];
        short muscle = physique[1];
        
        Console.WriteLine("");

        Character character = new Character(Guid.NewGuid(), forename, surname, sexType, age, fat, muscle);
        Console.WriteLine("You are " + character.Physique);

        return character;
    }

    static string SurnameInput()
    {
        string _surname;
        do
        {
            Console.Write("Surname: ");
            Console.Write("(fill name here if mononym) \n");
            _surname = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(_surname)); // Improved validation
        Console.WriteLine("Your surname is: " + _surname);
        return _surname;
    }

    static string ForenameInput()
    {
        string _forename;
        Console.Write("Forename: ");
        _forename = Console.ReadLine();
        Console.WriteLine("Your forename is: " + _forename);
        if (string.IsNullOrWhiteSpace(_forename))
        {
            return " ";
        }else return _forename;
    }

    static SexType InputSexType(){
        
        SexType _sexType=SexType.Masculine;
        Console.WriteLine("================");
        Console.WriteLine("Choose your sex:");
        Console.Write("Sex: \n 1. Male \n 2. Female \n 3. Hermaphrodite\n");

        short _chooseSex;
        while (!short.TryParse(Console.ReadLine(), out _chooseSex) || _chooseSex < 1 || _chooseSex > 3)
        {
            Console.WriteLine("Invalid input. Please choose a valid option (1, 2, or 3): ");
        }

        bool keepLooking = true;
        while (keepLooking)
        {
        switch (_chooseSex)
        {
            case 1:
                Console.WriteLine("Your sex is Male");
                _sexType = SexType.Masculine;
                keepLooking = false;
                break;
            case 2:
                Console.WriteLine("Your sex is Female");
                _sexType = SexType.Feminime;
                keepLooking = false;
                break;
            case 3:
                Console.WriteLine("Your sex is Hermaphrodite");
                _sexType = SexType.Hermaphrodite;
                keepLooking = false;
                break;
            default:
                // Fallback (shouldn't be reached due to validation)
                Console.WriteLine("Please choose a valid option (1, 2, or 3): ");
                _sexType = SexType.Masculine;
                keepLooking = true;
                break;
        }

        }
        return _sexType;
    }

    static int InputAge(){
        int _age;
        Console.Write("Age: ");
        while (!int.TryParse(Console.ReadLine(), out _age) || _age <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid age: ");
        }
        Console.WriteLine("Your age is: " + _age);
        Console.WriteLine("");
        return _age; 
    }

    static short[] InputPhysique(){
        // Physique declaration
        short _fat;
        short _muscle;
        Console.WriteLine("Character Physique");
        Console.WriteLine("==================");

        // Fat input with validation
        Console.Write("Fat (0--6): ");
        while (!short.TryParse(Console.ReadLine(), out _fat) || _fat < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid fat level: ");
        }
        Console.WriteLine("Your fat is: " + _fat);
        Console.WriteLine("");

        // Muscle input with validation
        Console.Write("Muscle (0--6): ");
        while (!short.TryParse(Console.ReadLine(), out _muscle) || _muscle < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid muscle level: ");
        }

        short[] _physique = [_fat, _muscle];
        return _physique;
    }
}
