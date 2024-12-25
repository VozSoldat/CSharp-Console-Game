// See https://aka.ms/new-console-template for more information
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
        
        // views
        View bedroom = new Bedroom();
        View closet = new Closet();

        AppController appController= new AppController();
        appController.Run();
    }

    
}
