//Jordan Malmstrom TownShip final project
Console.Clear();

//the starting part
Console.WriteLine("This is a game called township. A game where you can control what happens.\nBe careful there is no saving");
Console.WriteLine("What would you like to be in called: (this can not be changed later on)");
string? name = Console.ReadLine();
//knowledge about what the game is about
Console.WriteLine($"Hello {name} are you finally ready to play now, well then lets get going.\nThe setting is a medieval village.\nYou will hopefully get to explore as much as you can.\nYou wont be able to save as stated above ");
Console.WriteLine("Pless any key to continue.");
char temp;
temp = Console.ReadKey(true).KeyChar;
Console.Clear();
Console.WriteLine("This is a picture of the map, you wont be able to see it again until later on.");
string mapTown = File.ReadAllText("map.txt");
Console.WriteLine(mapTown);
Console.WriteLine("After studying the map please pless any key to continue.");

temp = Console.ReadKey(true).KeyChar;
Console.Clear();

//my array to say hey in different ways
string[] hey = {
    "Top of the morning to you"
};
Random rand = new Random();
int randHey = rand.Next(0,hey.Count());
string TheHey = hey[randHey];
string[] Chrch = {
    "are you here for church?",
    "come on in, your just in time for mass.",
    
};
Random rand1 = new Random();
int randChrch = rand1.Next(0,hey.Count());
string TheChrch = hey[randChrch];
int tre =0;
while(tre ==0)
{
    Console.Title = "Town";

    Console.WriteLine($"Welcome,{name} where would you like to visit first?");
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
            Cem(TheHey);
            break;
        case "3":
            {
              Foun();
                break;
            }
        case "4":
            {
                
                Shop();
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
  
}

static void Cem(string TheHey)
{

}

static void Foun()
{

}
static void Shop()
{

}
