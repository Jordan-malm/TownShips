﻿//Jordan Malmstrom TownShip final project
Console.Clear();

//the starting part
Console.WriteLine("This is a game called township. A game where you can control what happens.\nBe careful there is no saving");
Console.WriteLine("What would you like to be in called: (this can not be changed later on)");
string? name = Console.ReadLine();
//i want to see the names being used
File.WriteAllText("names.txt", name);  
//knowledge about what the game is about
Console.WriteLine($"Hello {name} are you finally ready to play now, well then lets get going.\nThe setting is a medieval village.\nYou will hopefully get to explore as much as you can.\nYou wont be able to save as stated above ");
Console.WriteLine("Pless any key to continue.");
char temp;
temp = Console.ReadKey(true).KeyChar;
Console.Clear();
//map
Console.WriteLine("This is a picture of the map, you wont be able to see it again until later on.");
string mapTown = File.ReadAllText("map.txt");
Console.WriteLine(mapTown);
Console.WriteLine("After studying the map please pless any key to continue.");

temp = Console.ReadKey(true).KeyChar;
Console.Clear();
int tre =0;
//the while loop 
while(tre ==0)
{
//my array to say hey in different ways
string[] hey = {
    "Top of the morning to you,",
    "Hello there,",
    "Good morning,",
    "Good day,",
    "Hey there,"
};
Random rand = new Random();
int randHey = rand.Next(0,hey.Count());
string TheHey = hey[randHey];
string[] Chrch = {
    "are you here for church?",
    "so glad you could come today stranger.",
    "come on in, your just in time for mass.",
    

};
Random rand1 = new Random();
int randChrch = rand1.Next(0,Chrch.Count());
string TheChrch = Chrch[randChrch];
string[] Shp = {
    "have you heard about the ghost that been sighted around the cemetery.",
    "would you like to check out our shop.",
    "we have the cheapest goods around.",
    "the priest has been acting differently recent, but i guess you wouldn't know."

};
Random rand2 = new Random();
int randShop = rand2.Next(0,Shp.Count());
string TheShp = Shp[randShop];
string[] Fond = {
   "Marge was found pregnant.",
   "I am so excited to go outside the town its so boring.",
   "I wish I could enjoy this day forver."

};
Random rand3 = new Random();
int randFoun = rand2.Next(0,Fond.Count());
string TheFoun = Fond[randFoun];


    Console.Title = "Town";

    Console.WriteLine($"Welcome, {name} where would you like to visit?");
    Console.WriteLine("");
    Console.WriteLine("[1]Church");
    Console.WriteLine("[2]Cemetery");
    Console.WriteLine("[3]The fountain");
    Console.WriteLine("[4]The shops at town square");
    Console.WriteLine("[5]Exit");
    string? input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Church(TheHey, TheChrch);
            break;
        case "2":
            Cem(TheHey, name, tre);
            break;
        case "3":
            {
              Foun(TheFoun);
                break;
            }
        case "4":
            {
                
                Shop(TheShp, TheHey, name);
                break;
            }
            case "5":
            {
                tre++;

                break;
            }
        default:
            break;

  }
}




static void Church(string TheHey, string TheChrch)
{
    Console.Clear();
  Console.WriteLine($"{TheHey} {TheChrch}");
}

static void Cem(string TheHey, string? name, int tre)
{
    Console.Clear();
   Random rand10 = new Random();
    int CemVault= rand10.Next(0,20);
    const int onefive = 15;
    if (CemVault > onefive)
    {  
        Console.WriteLine("You choose a random direction to walk in.\nYou continue down the path and see a vault thats door is half open.");
        Console.Title= "Cemetery";
        Console.WriteLine($"{name}, you have choices to make now. ");
        Console.WriteLine("[1] leave");
        Console.WriteLine("[2] explore the vault");
        
        string? input = Console.ReadLine();
        switch (input)
        {
           case "1":
           
            break;
            case "2":
            {
                Console.WriteLine("You found the ghost that has been sighted around the cemetary.\nYou talk to the ghost and lay them down to rest.");
               tre++;
                break;
            }
          
            
       
        }

    }
}

static void Foun(string TheFoun)
{
Console.WriteLine(TheFoun);
}
static void Shop(string TheShp,string TheHey, string name)
{
 Console.Clear();
  Console.WriteLine($"{TheHey} {name}, {TheShp}");  
}

