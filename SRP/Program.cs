using Settings;
using SRP;

var root = Startup.GetAppConfiguration(); // Из стат. класса получаем конфигурацию, где задаются попытки и диапазон.
var count = Convert.ToInt32(root["Count"]);
int rangeNumbers = Convert.ToInt32(root["RangeNumbers"]);

Random rnd = new Random();
var searchNumber = rnd.Next(0, rangeNumbers);

Game game = new Game(); // Согласно принципу SRP, логику связанную с игровым процессом вынес в отдельный класс.
game.Start(count, searchNumber);