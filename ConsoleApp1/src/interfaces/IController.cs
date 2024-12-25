

using ConsoleApp1.src.controllers;
using ConsoleApp1.src.views;

public interface IController
{
    public View View{get;set;}
    public AppController AppController{get;set;}
    public string? Choice{get;set;}
    public void Run();
    public void handleChoice();
}