public class RemoveTaskCommand {
    public static void Execute(string[] commandArgs) {
        if (commandArgs.Length != 2) {
            throw new ArgumentException("Usage: remove <title>");
        }

        string title = commandArgs[1];
        Task? task = TaskManager.RemoveTask(title);
        if (task == null) {
            Console.WriteLine("That task does not exist.");
            return;
        }

        Console.WriteLine($"Task '{task.Title}' has been removed");
    }
}