using OCP;
using Settings;

var root = Startup.GetAppConfiguration();
var count = Convert.ToInt32(root["Count"]);
int rangeNumbers = Convert.ToInt32(root["RangeNumbers"]);

Random rnd = new Random();
var searchNumber = rnd.Next(0, rangeNumbers);

// Согласно принципу OCP, сделал реализацию интерфейса IGame.
StartGame gm = new StartGame(new SearchNumberGame());
gm.Start(count, searchNumber); 


