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
