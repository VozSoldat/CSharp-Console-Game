using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.models;
using ConsoleApp1.src.models.Character;

namespace ConsoleApp1.src.tools;
public static class RandomGenerator
{
    public static string GenerateMaleForename()
    {
        string[] registry ={
            "James", "John", "Robert", "Michael", "William",
            "David", "Joseph", "Thomas", "Charles", "Christopher",
            "Daniel", "Matthew", "Anthony", "Mark", "Donald",
            "Steven", "Paul", "Andrew", "Joshua", "Kenneth",
            "Kevin", "Brian", "George", "Edward", "Ronald",
            "Timothy", "Jason", "Jeffrey", "Ryan", "Jacob"
        };

        Random random = new Random();

        return registry[random.Next(registry.Length)];
    }
    public static string GenerateFemaleForename()
    {
        string[] registry ={
            "Emma",
            "Olivia",
            "Ava",
            "Isabella",
            "Sophia",
            "Mia",
            "Charlotte",
            "Amelia",
            "Harper",
            "Evelyn",
            "Abigail",
            "Emily",
            "Lily",
            "Madison",
            "Victoria",
            "Jessica",
            "Samantha",
            "Avery",
            "Riley",
            "Zoey",
            "Natalie",
            "Grace",
            "Hannah",
            "Elizabeth",
            "Taylor",
            "Kayla",
            "Hailey",
            "Jasmine",
            "Julia",
            "Sydney"
        };

        Random random = new Random();
        return registry[random.Next(registry.Length)];
    }
    public static string GenerateSurname()
    {
        string[] registry =
        {
            "Smith",
            "Johnson",
            "Williams",
            "Brown",
            "Jones",
            "Davis",
            "Miller",
            "Wilson",
            "Moore",
            "Taylor",
            "Anderson",
            "Thomas",
            "Jackson",
            "White",
            "Harris",
            "Martin",
            "Thompson",
            "Garcia",
            "Martinez",
            "Robinson",
            "Clark",
            "Rodriguez",
            "Lewis",
            "Lee",
            "Walker",
            "Hall",
            "Allen",
            "Young",
            "Hernandez",
            "King"
        };
        Random randomGenerator = new Random();
        return registry[randomGenerator.Next(registry.Length)];
    }

    public static SexType GenerateSexType()
    {
        Random randomGenerator = new Random();
        return (SexType)randomGenerator.Next(0, 2);
    }

    public static int GenerateIntAge()
    {
        Random randomGenerator = new Random();
        return randomGenerator.Next(17, 23);
    }

    public static short GenerateFat()
    {
        Random randomGenerator = new Random();
        return (short)randomGenerator.Next(0, 7);
    }
    public static short GenerateMuscle()
    {
        Random randomGenerator = new Random();
        return (short)randomGenerator.Next(0, 7);
    }

}
