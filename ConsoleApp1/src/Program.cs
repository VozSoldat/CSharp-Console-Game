﻿// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using ConsoleApp1.src.views;
using ConsoleApp1.src.models;
using ConsoleApp1.src.controllers;
using ConsoleApp1.src.models.Character;
using System.Security.Cryptography.X509Certificates;
using ConsoleApp1.src.tools;
namespace ConsoleApp1.src;

static public class Program
{
    public static void Main(string[] args)
    {
        Character playerCharacter = CharacterCreation.PlayerCharacterCreation();
        CharactersRegistry charactersRegistry = new CharactersRegistry();
        populateCharacterRegistry(charactersRegistry);

        IController appController = new AppController();
        // views
        View bedroom = new Bedroom(appController);
        View closet = new Closet(appController);


    }

    static void populateCharacterRegistry(CharactersRegistry charactersRegistry)
    {
        int number=20;
        for (int i = 0; i < number; i++)
        {
            charactersRegistry.AddCharacter(RandomGenerator.GenerateCharacter());
        }
    }
}
