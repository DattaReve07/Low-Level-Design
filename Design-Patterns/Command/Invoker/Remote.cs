using Command.Command;

namespace Command.Invoker;

public class Remote
{
    private ICommand? command;
    private readonly Stack<ICommand> commandHistory = new();

    public void SetCommand(ICommand commandToSet)
    {
        command = commandToSet;
    }
    public void OkButton()
    {
        if(command == null)   return;
        command.Execute();
        commandHistory.Push(command);
    }

    public void BackButton()
    {
        if(commandHistory.Count == 0)   return;
        command = commandHistory.Pop();
        command.Undo();
    }
}