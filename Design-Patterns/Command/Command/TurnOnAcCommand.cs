using Command.Receiver;

namespace Command.Command;

public class TurnOnAcCommand(AirConditioner airConditioner) : ICommand
{
    public void Execute()
    {
        airConditioner.On();
    }

    public void Undo()
    {
        airConditioner.Off();
    }
}