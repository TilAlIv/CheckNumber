using DIP;
using Settings;

var root = Startup.GetAppConfiguration();
var count = Convert.ToInt32(root["Count"]);
int rangeNumbers = Convert.ToInt32(root["RangeNumbers"]);

Random rnd = new Random();
var searchNumber = rnd.Next(0, rangeNumbers);

List<IGame> list = new List<IGame>(){new Game1(), new Game2()};
foreach (var game in list)
{
    game.Start(count, searchNumber);
}