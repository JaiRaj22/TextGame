using oopadv;

Text.LoadLanguage(new English());

Console.WriteLine(Text.Language.Chooseyourname);
var name = Console.ReadLine();
if (name == String.Empty)
{
    name = Text.Language.Defaultname;
}
var player = new Player(name);
Console.WriteLine(Text.Language.Welcome, player.Name);

var house = new House(player);
Actions.Instance.Register(new Go(house));
var run = true;
Room lastroom  = null;
while (run)
{
    if (lastroom != house.Currentroom)
    {
        Console.WriteLine(house.Currentroom.ToString());
        lastroom = house.Currentroom;
    }
    Console.WriteLine(Text.Language.Whattodo);
    var input = Console.ReadLine().ToLower();
    if (input == Text.Language.Quit)
    {
        run = false;
    }
    else
        Actions.Instance.Execute(input.Split(" "));
}