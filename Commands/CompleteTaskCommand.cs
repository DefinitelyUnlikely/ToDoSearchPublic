public class CompleteTaskCommand {
    public static void Execute(string[] commandArgs) {
        if (commandArgs.Length != 2) {
            throw new ArgumentException("Usage: complete <title>");
        }

        string title = commandArgs[1];
        Task? task = TaskManager.GetTask(title);
        if (task == null) {
            Console.WriteLine("That task does not exist.");
            return;
        }

        task.Completed = true;
        Console.WriteLine($"Task '{task.Title}' has been marked as completed.");
    }
}