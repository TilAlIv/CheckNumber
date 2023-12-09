using LSP;
using Settings;

var root = Startup.GetAppConfiguration();
var count = Convert.ToInt32(root["Count"]);
int rangeNumbers = Convert.ToInt32(root["RangeNumbers"]);

Random rnd = new Random();
var searchNumber = rnd.Next(0, rangeNumbers);

List<Game> list = new List<Game>(){new CheckNumber(), new CheckWord()};
foreach (var game in list)
{
    if (game is CheckNumber)
    {
        game.StartSearchNumber(count, searchNumber);
    }
    else
    {
        game.StartSearchWord();
    }
}