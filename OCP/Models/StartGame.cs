namespace OCP;

public class StartGame
{
    private readonly IGame _game;
    public StartGame(IGame game)
    {
        _game = game;
    }
    public void Start(int count, int searchNumber)
    {
        _game.Start(count, searchNumber);
    }
}