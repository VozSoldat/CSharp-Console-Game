using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.models.Character;
using ConsoleApp1.src.tools;

namespace ConsoleApp1.src.controllers
{
    public class CharactersRegistry
    {
        private readonly Dictionary<Guid, Character> characters = new(); // <Guid, Character>

        public void AddCharacter(Character character)
        {
            characters.Add(character.ID, character);
        }

        public Character GetCharacter(Guid characterID)
        {
            if (characters.TryGetValue(characterID, out Character character))
            {
                return character;
            }
            throw new Exception("Character not found");
        }

        public void ShowAllCharacter()
        {
            foreach (var character in characters)
            {
                Console.WriteLine(character.Value.Forename + " " + character.Value.Surname);
            }
        }

        public void PopulateRandom(int number)
        {
            for (int i = 0; i < number; i++)
            {
                AddCharacter(RandomGenerator.GenerateCharacter());
            }
        }
    }
}