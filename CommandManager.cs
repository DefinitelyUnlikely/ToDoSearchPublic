public class CommandManager
{
    public static void TryExecuteCommand(string input)
    {
        if (input.Length == 0)
        {
            throw new ArgumentException("Command is empty.");
        }

        string[] commandArgs = input.Split(" ");

        if (commandArgs[0].Equals("create"))
        {
            CreateTaskCommand.Execute(commandArgs);
        }
        else if (commandArgs[0].Equals("remove"))
        {
            RemoveTaskCommand.Execute(commandArgs);
        }
        else if (commandArgs[0].Equals("stop") || commandArgs[0].Equals("exit"))
        {
            StopCommand.Execute(commandArgs);
        }
        else if (commandArgs[0].Equals("list"))
        {
            ListTasksCommand.Execute(commandArgs);
        }
        else if (commandArgs[0].Equals("complete"))
        {
            CompleteTaskCommand.Execute(commandArgs);
        }
        else if (commandArgs[0].Equals("search"))
        {
            SearchTaskCommand.Execute(commandArgs);
        }
        else if (commandArgs[0].Equals("help"))
        {
            HelpCommand.Execute(commandArgs);
        }
        else if (commandArgs[0].Equals("populate"))
        {
            CreateTaskCommand.Populate();
        }
    }
}
