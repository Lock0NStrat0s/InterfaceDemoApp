
List<IComputerController> controllers = new List<IComputerController>();

Keyboard keyboard = new Keyboard();
GameController gameController = new GameController();
BatterPoweredGameController batterPoweredGameController = new BatterPoweredGameController();
BatteryPoweredKeyboard batteryPoweredKeyboard = new BatteryPoweredKeyboard();

controllers.Add(keyboard);
controllers.Add(gameController);
controllers.Add(batterPoweredGameController);

foreach (IComputerController controller in controllers)
{
    if (controller is GameController gc)
    {
        
    }

    if (controller is IBatteryPowered powered)
    {
        
    }
}

List<IBatteryPowered> powereds = new List<IBatteryPowered>();

powereds.Add(batterPoweredGameController);
powereds.Add(batteryPoweredKeyboard);

public interface IComputerController
{
    void Connect();
    void CurrentKeyPressed();
}

public class Keyboard : IComputerController
{
    public void Connect()
    {

    }

    public void CurrentKeyPressed()
    {

    }

    public string Connection { get; set; }
}

public interface IBatteryPowered
{
    int BatteryLevel { get; set; }
}

public class BatteryPoweredKeyboard : IBatteryPowered
{
    public int BatterLevel { get; set; }
}

public class GameController : IComputerController, IDisposable
{
    public void Connect()
    {

    }

    public void CurrentKeyPressed()
    {

    }

    public void Dispose()
    {

    }

    public int BatteryLevel { get; set; }
}

public class BatterPoweredGameController : GameController, IBatteryPowered
{
    public int BatteryLevel { get; set; }

}