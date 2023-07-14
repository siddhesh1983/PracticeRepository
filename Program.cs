// See https://aka.ms/new-console-template for more information
using PracticeConsoleApp;

Console.WriteLine("Hello, World!");

BaseLogic baseLogic = new Logic("Siddhesh" , "Sawant");

BaseLogic derivedLogic = new DerivedLogic("Shreyasi", "Sawant");

var baseFormattedString =baseLogic.GetFormattedString();
var derivedFormattedString = derivedLogic.GetFormattedString();

Console.WriteLine($"this is base formatted string {baseFormattedString} ");

Console.WriteLine($"this is base formatted string {derivedFormattedString} ");

Console.ReadLine();
