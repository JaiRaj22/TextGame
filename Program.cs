using oopadv;

var language = new English();

Console.WriteLine(language.Chooseyourname);
var name = Console.ReadLine();
if (name == String.Empty)
{
    name = "No name";
}
var player = new Player(name);
Console.WriteLine("welcome {0} to your oop adventure", player.Name);
