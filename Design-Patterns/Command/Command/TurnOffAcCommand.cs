using Command.Receiver;

namespace Command.Command;

public class TurnOffAcCommand(AirConditioner airConditioner) : ICommand
{
    public void Execute()
    {
        airConditioner.Off();
    }

    public void Undo()
    {
        airConditioner.On();
    }
}