using ISP;
using Settings;

var root = Startup.GetAppConfiguration();
var count = Convert.ToInt32(root["Count"]);
int rangeNumbers = Convert.ToInt32(root["RangeNumbers"]);

Random rnd = new Random();
var searchNumber = rnd.Next(0, rangeNumbers);

Game gm = new Game();
gm.Start(count, searchNumber);

