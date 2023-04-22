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

//the amount of times you can use the for loop
Random rand = new Random();
int ranLength = rand.Next(0, 100);

for (int i = 0; i < ranLength; i++)
{
    Console.Title = "Town";

    Console.WriteLine($"Welcome,{name} where would you like to visit first?");
    Console.WriteLine("");
    Console.WriteLine("[1]Church");
    Console.WriteLine("[2]Cemetery");
    Console.WriteLine("[3]The fountain");
    Console.WriteLine("[4]the shops at town square");
    string? input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Church();
            break;
        case "2":
            //Fibonacci();
            break;
        case "3":
            {
                //number1_20();
                break;
            }
        case "4":
            {
                //tre++;

                break;
            }
        default:
            break;

    }
}
static void Church()
{
    
}

