// See https://aka.ms/new-console-template for more information
using PracticeConsoleApp;

Console.WriteLine("Hello, World!");

BaseLogic baseLogic = new Logic("First name" , "Last Name");

BaseLogic derivedLogic = new DerivedLogic("Second name", "Second last Name");

baseLogic.GetFormattedString();
derivedLogic.GetFormattedString();

Console.ReadLine();
